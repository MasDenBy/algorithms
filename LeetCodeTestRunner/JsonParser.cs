using System.Collections.Generic;
using System.Text;
using System.Text.Json;

using LeetCodeTestRunner.Entities;

namespace LeetCodeTestRunner
{
	internal static class JsonParser
	{
		public static Queue<UnitTestOperator> Parse(string input, string expected)
		{
			var result = new Queue<UnitTestOperator>();
			var json = JsonParser.PrepareJsonDocument(input, expected);
			var operations = JsonSerializer.Deserialize<CodeOperation>(json);

			result.Enqueue(new ConstructorOperator(operations.Operators[0]));

			for (int i = 1; i < operations.Operators.Count; i++)
			{
				if(operations.Expected?[i] == null)
				{
					result.Enqueue(new ActionOperator(
						operations.Operators[i], 
						operations.Params[i]));
				}
				else
				{
					result.Enqueue(new FunctionOperator(
						operations.Operators[i], 
						operations.Params[i],
						operations.Expected[i]));
				}
			}

			return result;
		}

		private static string PrepareJsonDocument(string input, string expected)
		{
			var operatorsEnd = input.IndexOf("]") + 1;
			var paramsStart = operatorsEnd;

			var sb = new StringBuilder();
			sb.Append("{")
			  .Append(@"""Operators"":")
			  .Append(input.Substring(0, operatorsEnd))
			  .Append(@",""Params"":")
			  .Append(input.Substring(paramsStart, input.Length - paramsStart))
			  .Append(string.IsNullOrWhiteSpace(expected) ? "" : @",""Expected"":")
			  .Append(expected)
			  .Append("}");

			return sb.ToString();
		}

		private class CodeOperation
		{
			public IList<string> Operators { get; set; }
			public IList<object[]> Params { get; set; }
			public IList<object> Expected { get; set; }
		}
	}
}