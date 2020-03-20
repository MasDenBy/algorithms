namespace Algorithms.Text
{
	/// <summary>
	/// The example of realization StringBuilder.
	/// </summary>
	public class StringBuilder
	{
		private const int InitialLength = 50;

		private char[] chars;
		private int currentItemIndex;

		public StringBuilder()
			:this(InitialLength)
		{ }

		public StringBuilder(int length)
		{
			this.chars = new char[length];
			this.currentItemIndex = 0;
		}

		public StringBuilder Append(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
				return this;

			this.AllocateMoreSpaceIfNeeded(value.Length);

			for (int i = 0; i < value.Length; i++)
				this.chars[this.currentItemIndex++] = value[i];

			return this;
		}

		public override string ToString()
		{
			return new string(this.chars, 0, this.currentItemIndex);
		}

		private void AllocateMoreSpaceIfNeeded(int need)
		{
			if (need < this.chars.Length - this.currentItemIndex)
				return;

			int newLength = this.chars.Length * 2;

			while (need > newLength - this.currentItemIndex)
				newLength *= 2;

			var newCharacters = new char[newLength];
			this.chars.CopyTo(newCharacters, 0);

			this.chars = newCharacters;
		}
	}
}