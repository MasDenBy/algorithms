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

			var sb = new StringBuilder();

			while (operators.Count > 0)
			{
				sb.Append(operators.Dequeue().ToString());
				sb.Append(";");
			}

			await CSharpScript.EvaluateAsync(sb.ToString(), GetScriptOptions());
		}

		private ScriptOptions GetScriptOptions() =>
			ScriptOptions.Default.WithReferences(typeof(T).Assembly, typeof(Assert).Assembly)
								 .AddImports(typeof(T).Namespace, typeof(Assert).Namespace);
	}
}