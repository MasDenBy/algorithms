namespace Algorithms.Collection
{
	public interface ICircularDeque
	{
		bool InsertFront(int value);
		bool InsertLast(int value);
		bool DeleteFront();
		bool DeleteLast();
		int GetFront();
		int GetRear();
		bool IsEmpty();
		bool IsFull();
	}
}