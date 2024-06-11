namespace MonadsAreCool
{
    public interface IMonad<T>
    {
        IMonad<V> Bind<V>(Func<T, IMonad<V>> func);
    }
}
