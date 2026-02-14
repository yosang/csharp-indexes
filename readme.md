# C# Indexer Example
Simple demonstration of indexers in C#.

Indexers are class members similar to properties, that allow us to get / set values to an object that is used with an index, like an array for example.

# Key points:
- They use `get` and `set`.
- They are defined with the `this` keyword.
- They are defined with square brackets `[]` instead of parenthesis `()`.
- They are commonly used with arrays.

# Why should we care?
Consider this class method

```c#
public string GetAnimal(int index)
    {
        return animalList[index];
    }
```

It does return an item by its index, when we call it with an index, however the syntax becomes cumbersome and repetitive: `myAnimal.GetAnimal(2)`.

We can instead use an indexer

```c#
public string this[int index]
{
    get => animalList[index];
    set => animalList[index] = value;
}
```

And now can just retrieve and set animals like we would in a normal array: `myAnimal[0]` and `myAnimal[2] = "Yoda"`.


# Summary

Indexers provide better syntax, more intuitive usage.

The code is commented so we can keep this readme short.