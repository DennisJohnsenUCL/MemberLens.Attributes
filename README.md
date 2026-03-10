## MemberLens.Attributes

Provides MemberAccessorAttribute for the **MemberLens** VS extension.

This NuGet package lets you decorate string parameters so they receive autocomplete suggestions for public and private member names of a given type.

---
### Usage

#### Explicit Type — Field Names

Suggests field names from `Test1`:

```csharp
public class Test2 {
    public void TestMethod(
        [MemberAccessor(AccessorType.Field, typeof(Test1))]
        string testParameter
    ) { }
}
```

---
#### Generic Class Parameter — Method Names

Suggests method names from `T`, the first generic parameter on the class:

```csharp
public class Test3<T> {
    public void TestMethod(
        [MemberAccessor(AccessorType.Method, GenericSource.Class, index: 0)]
        string testParameter
    ) { }
}
```

---
#### Generic Method Parameter — Field Names

Suggests field names from `T2`, the second generic parameter on the method:

```csharp
public class Test4 {
    public void TestMethod<T1, T2>(
        [MemberAccessor(AccessorType.Field, GenericSource.Method, index: 1)]
        string testParameter
    ) { }
}
```

---
#### Constructor Overloads
| Overload | Description |
|---|---|
| MemberAccessor(AccessorType, Type) | Members from an explicit type |
| MemberAccessor(AccessorType, GenericSource, int index) | Members from a generic type parameter |

#### AccessorType
| Value | Description |
|---|---|
| Field | Instance and static fields |
| Method | Instance and static methods |

#### GenericSource
| Value | Description |
|---|---|
| Class | Generic parameter from the containing class |
| Method | Generic parameter from the containing method |
