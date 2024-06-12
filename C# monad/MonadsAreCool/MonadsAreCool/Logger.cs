namespace MonadsAreCool
{
    public class Logger<T> : IMonad<T>
    {
        public T Value { get; }

        public Logger(T inner)
        {
            Value = inner;
        }

        public IMonad<V> Bind<V>(Func<T, IMonad<V>> func)
        {
            Logger<V> m = (Logger<V>)func(Value);
            Console.WriteLine(m.Value);
            return m;
        }

        public override string ToString()
        {
            return $"Logger {{ Value = {Value} }}";
        }
    }
}
