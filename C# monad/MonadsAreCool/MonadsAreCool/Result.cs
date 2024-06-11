using System.Diagnostics;

namespace MonadsAreCool
{
    public record Result<T, E> : IMonad<T>
    {
        private Result() { }

        public sealed record Ok(T value) : Result<T, E>;
        public sealed record Err(E err) : Result<T, E>;
        public IMonad<V> Bind<V>(Func<T, IMonad<V>> func) => this switch
        {
            Ok o => func(o.value),
            Err e => new Result<V, E>.Err(e.err),
            _ => throw new UnreachableException(),
        };
    }
}
