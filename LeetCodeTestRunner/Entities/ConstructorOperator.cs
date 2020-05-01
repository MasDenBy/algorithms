namespace LeetCodeTestRunner.Entities
{
	internal class ConstructorOperator : UnitTestOperator
	{
		public ConstructorOperator(string name)
			: base(name)
		{
		}

		public override string ToString()
		{
			return $"var {this.VariableName} = new {this.Name}()";
		}
	}
}