# CSharp
C# Overview

## Import static
```c#
using static System.Console;
public class CSharp {
  public static void Main(string[] args) {
    WriteLine("Hello World!");
  }
}
```

## Short constructor
```c#
Dictionary<int,string> dic = new();
```

## Array slicing
```c#
    int[] nums = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

    WriteLine(nums[^1]); // Last element
    WriteLine(nums[^2]); // Second Last element

    int[] firstThree = nums[0..3];
    Array.ForEach(firstThree, n => Write(n));
    WriteLine();

    int[] lastThree = nums[^3..];
    Array.ForEach(lastThree, n => Write(n));
    WriteLine();

    int[] midElements = nums[3..6];
    Array.ForEach(midElements, n => Write(n));
    WriteLine();
```

## Expression-bodied methods
```c#
public class CSharp {
  public static void Main(string[] args) {
    WriteLine(Now());
  }
  static string Now() => DateTime.Now.ToLongDateString();
}
```
