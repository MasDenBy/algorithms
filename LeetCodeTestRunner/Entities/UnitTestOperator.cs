namespace LeetCodeTestRunner.Entities
{
	internal abstract class UnitTestOperator
	{
		protected UnitTestOperator(string name)
		{
			this.Name = name[0].ToString().ToUpper() + name.Substring(1);
		}

		public string Name { get; set; }
		protected string VariableName => "obj";
	}
}