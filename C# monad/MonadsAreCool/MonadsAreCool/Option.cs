using System.Diagnostics;

namespace MonadsAreCool
{
    public record Option<T> : IMonad<T>
    {
        private Option() {}
        public sealed record Some(T value) : Option<T>;
        public sealed record None() : Option<T>;
        public IMonad<V> bind<V>(Func<T, IMonad<V>> func) => this switch
        {
            Some v => func(v.value),
            None => new Option<V>.None(),
            _ => throw new UnreachableException("Cannot enter here")
        };
    }
}
