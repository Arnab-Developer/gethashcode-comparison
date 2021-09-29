# GetHashCode comparison

This is a comparison of `Object.GetHashCode()` value between `class` and `record`.

If you have a class

```csharp
class StudentClass
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
```

and you have created an object of that class

```csharp
StudentClass s1 = new() { Id = 1, FirstName = "Jon", LastName = "Doe" };
```

Now if you called `GetHashCode()` on it multiple times you will get same values. If
you restart the app, you will get same values again.

```csharp
WriteLine(s1.GetHashCode());
WriteLine(s1.GetHashCode());
WriteLine(s1.GetHashCode());
WriteLine(s1.GetHashCode());
```

But if you do the same thing with `record` you will get same values for same object but
if you restart the app, you will get different set of values.