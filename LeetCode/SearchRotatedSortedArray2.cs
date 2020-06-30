namespace LeetCode
{
	/// <summary>
	/// 81. Search in Rotated Sorted Array II
	/// </summary>
	public class SearchRotatedSortedArray2
	{
		public bool Search(int[] nums, int target)
		{
			if (nums.Length == 0) return false;
			if (nums.Length == 1) return nums[0] == target;

			var pivot = FindPivot(nums, 0, nums.Length - 1, target);

			if (nums[pivot] == target) return true;
			if (nums[0] <= target && nums[pivot - 1] >= target) return BinarySearch(nums, 0, pivot - 1, target) > -1;
			else return BinarySearch(nums, pivot + 1, nums.Length - 1, target) > -1;
		}

		private static int FindPivot(int[] nums, int start, int end, int target)
		{
			if (start > end) return end;

			var middle = (start + end) / 2;

			if (nums[middle] == target) return middle;

			if (middle > 0 && nums[middle - 1] > nums[middle]) return middle;
			else if (middle < nums.Length - 1 && nums[middle] > nums[middle + 1]) return middle + 1;

			if(nums[start] == nums[middle] && nums[middle] == nums[end])
			{
				for (int i = start; i < end; i++)
				{
					if(nums[start] != nums[i])
					{
						return i < middle
							? FindPivot(nums, i, middle, target)
							: FindPivot(nums, middle, i, target);
					}
				}
			}

			return nums[start] > nums[middle] 
				? FindPivot(nums, 0, middle, target) 
				: FindPivot(nums, middle + 1, end, target);
		}

		private static int BinarySearch(int[] nums, int start, int end, int target)
		{
			if (start > end) return -1;

			var middle = (start + end) / 2;

			if (nums[middle] > target) return BinarySearch(nums, start, middle - 1, target);
			else if (nums[middle] < target) return BinarySearch(nums, middle + 1, end, target);
			else return middle;
		}
	}
}