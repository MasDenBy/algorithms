using System.Collections.Generic;
using System.Text;
using System.Text.Json;

using LeetCodeTestRunner.Entities;

namespace LeetCodeTestRunner
{
	internal static class JsonParser
	{
		internal static Queue<UnitTestOperator> Parse(string input, string expected)
		{
			var json = JsonParser.PrepareJsonDocument(input, expected);
			var operations = JsonSerializer.Deserialize<CodeOperation>(json);
			var result = new Queue<UnitTestOperator>();

			result.Enqueue(new ConstructorOperator(operations.Methods[0]));

			JsonParser.PopulateOperationsQueue(result, operations, start:1);

			return result;
		}

		internal static T Parse<T>(string value)
		{
			return JsonSerializer.Deserialize<T>(value);
		}

		private static string PrepareJsonDocument(string input, string expected)
		{
			var methodsEnd = input.IndexOf("]") + 1;
			var paramsStart = methodsEnd;

			var sb = new StringBuilder();
			sb.Append("{")
			  .Append(@"""Methods"":")
			  .Append(input.Substring(0, methodsEnd))
			  .Append(@",""Params"":")
			  .Append(input.Substring(paramsStart, input.Length - paramsStart))
			  .Append(string.IsNullOrWhiteSpace(expected) ? "" : @",""Expected"":")
			  .Append(expected)
			  .Append("}");

			return sb.ToString();
		}

		private static void PopulateOperationsQueue(Queue<UnitTestOperator> queue, CodeOperation codeOperation, int start = 0)
		{
			for (int i = start; i < codeOperation.Methods.Count; i++)
			{
				if (codeOperation.Expected?[i] == null)
				{
					queue.Enqueue(new ActionOperator(
						codeOperation.Methods[i],
						codeOperation.Params[i]));
				}
				else
				{
					queue.Enqueue(new FunctionOperator(
						codeOperation.Methods[i],
						codeOperation.Params[i],
						codeOperation.Expected[i]));
				}
			}
		}

		private class CodeOperation
		{
			public IList<string> Methods { get; set; }
			public IList<object[]> Params { get; set; }
			public IList<object> Expected { get; set; }
		}
	}
}