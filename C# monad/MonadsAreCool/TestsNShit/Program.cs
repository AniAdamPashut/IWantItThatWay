using MonadsAreCool;

IMonad<string> x = new Logger<int>(0)
    .Bind(x => new Logger<int>(x + 3))
    .Bind(x => new Logger<int>(x * 3))
    .Bind(x => new Logger<int>(x * x * x))
    .Bind(x => new Logger<string>(x.ToString()));

Console.WriteLine((Logger<string>)x);