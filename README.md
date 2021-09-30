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

The previous test has been done with a .NET 5 console app. If I do the same thing with ASP.NET 5 then the `Object.GetHashCode()` 
behaviour is opposite. There `Object.GetHashCode()` returns different value for every request
for the `class` objects but same for the `record` objects.

So the conclution is never store return value of `Object.GetHashCode()` out of application to
check the object equality.

> Furthermore, .NET does not guarantee the default implementation of the GetHashCode method, and the value 
> this method returns may differ between .NET implementations, such as different versions of .NET Framework 
> and .NET Core, and platforms, such as 32-bit and 64-bit platforms. For these reasons, do not use the default 
> implementation of this method as a unique object identifier for hashing purposes. Two consequences follow 
> from this:

> - You should not assume that equal hash codes imply object equality.
> - You should never persist or use a hash code outside the application domain in which it was created, because the same object may hash across application domains, processes, and platforms.

See this [document](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode?view=net-5.0#remarks)
