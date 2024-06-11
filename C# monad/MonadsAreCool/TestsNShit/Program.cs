using MonadsAreCool;

IMonad<int> x = new Logger<int>(0);
x = x.Bind(x => new Logger<int>(x + 3));
x = x.Bind(x => new Logger<int>(x * 3));
x = x.Bind(x => new Logger<int>(x * x * x));