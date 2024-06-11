namespace MonadsAreCool
{
    public interface IMonad<T>
    {
        IMonad<V> bind<V>(Func<T, IMonad<V>> func);
    }
}
