using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using NUnit.Framework;

namespace LeetCodeTestRunner
{
	public partial class LeetCodeTestRunner<T>
		where T : class
	{
		public async Task Run(string input, string expected)
		{
			var operators = JsonParser.Parse(input, expected);

			await this.RunOperator(operators);
		}

		public bool Run<TInput>(string parameters, Func<T, TInput, bool> method)
		{
			var param = JsonParser.Parse<TInput>(parameters);
			var obj = Activator.CreateInstance<T>();

			return method(obj, param);
		}

		private ScriptOptions GetScriptOptions() =>
			ScriptOptions.Default.WithReferences(typeof(T).Assembly, typeof(Assert).Assembly)
								 .AddImports(typeof(T).Namespace, typeof(Assert).Namespace);

		private async Task RunOperator(System.Collections.Generic.Queue<Entities.UnitTestOperator> operators)
		{
			var sb = new StringBuilder();

			while (operators.Count > 0)
			{
				sb.Append(operators.Dequeue().ToString());
				sb.Append(";");
			}

			await CSharpScript.EvaluateAsync(sb.ToString(), GetScriptOptions());
		}
	}
}