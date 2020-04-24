namespace LeetCode
{
	public class SortColors
	{
		public void Sort(int[] nums)
		{
			int[] temp = new int[nums.Length];
			nums.CopyTo(temp, 0);

			Sort(temp, nums, 0, nums.Length - 1);
		}

		private void Sort(int[] temp, int[] nums, int low, int high)
		{
			if(high <= low)
				return;

			int mid = low + (high - low) / 2;

			Sort(temp, nums, low, mid);
			Sort(temp, nums, mid + 1, high);

			Merge(temp, nums, low, mid, high);
		}

		private void Merge(int[] temp, int[] nums, int low, int middle, int high)
		{
			for (int i = low; i <= high; i++)
				temp[i] = nums[i];

			int left = low;
			int right = middle + 1;

			for (int index = low; index <= high; index++)
			{
				if (left > middle) nums[index] = temp[right++];
				else if (right > high) nums[index] = temp[left++];
				else if (temp[right] < temp[left]) nums[index] = temp[right++];
				else nums[index] = temp[left++];
			}
		}
	}
}