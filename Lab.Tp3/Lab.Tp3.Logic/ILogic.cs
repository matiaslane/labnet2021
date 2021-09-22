namespace Lab.Tp3.Logic
{
    public interface ILogic<T>
    {
        void Add(T newItem);
        void Update(T item);
    }
}