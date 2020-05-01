using System.Text;

namespace LeetCodeTestRunner.Entities
{
	internal class FunctionOperator : ActionOperator
	{
		public FunctionOperator(string name, object[] parameters, object expected)
			: base(name, parameters)
		{
			this.Expected = expected;
		}

		public object Expected { get; set; }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("Assert.");

			if(bool.TryParse(this.Expected.ToString(), out var resultBool))
			{
				sb.Append(resultBool ? "IsTrue(" : "IsFalse(");
			} else if (int.TryParse(this.Expected.ToString(), out var resultInt))
			{
				sb.Append($"AreEqual({resultInt}, ");
			}

			sb.Append(base.ToString());
			sb.Append(")");

			return sb.ToString();
		}
	}
}