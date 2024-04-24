from typing import Callable

def curryit(func: Callable):
    arguments = func.__code__.co_argcount
    def inner(argno, args):
        if argno == 0:
            return func(*args)
        return lambda x: inner(argno - 1, args + [x])
    
    return inner(arguments, [])


@curryit
def func(x, y, z):
    return x + y + z

print(func(1)(2)(3))