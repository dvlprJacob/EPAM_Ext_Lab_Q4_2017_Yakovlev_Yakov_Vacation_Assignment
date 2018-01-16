namespace Datastruct
{
    public interface IStack<TType> where TType : struct
    {
        void Push(TType newNode);

        void Pop();

        TType Top();

        int Size { get; }
    }
}