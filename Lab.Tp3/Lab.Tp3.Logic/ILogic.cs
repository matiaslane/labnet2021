namespace Lab.Tp7.Logic
{
    public interface ILogic<T>
    {
        void Add(T newItem);
        void Update(T item);
    }
}