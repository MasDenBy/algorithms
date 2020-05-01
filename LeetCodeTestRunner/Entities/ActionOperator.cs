namespace LeetCodeTestRunner.Entities
{
	internal class ActionOperator : UnitTestOperator
	{
		public ActionOperator(string name, object[] parameters)
			: base(name)
		{
			this.Parameters = parameters;
		}

		public object[] Parameters { get; private set; }

		public override string ToString()
		{
			var paramsStr = this.Parameters == null 
				? string.Empty 
				: string.Join(",", this.Parameters);

			return $"{this.VariableName}.{this.Name}({paramsStr})";
		}
	}
}