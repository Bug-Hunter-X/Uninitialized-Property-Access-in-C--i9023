# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property that hasn't been explicitly initialized before usage. This can lead to unexpected behavior and potential bugs in your application.

## The Bug
The `MyProperty` in `ExampleClass` is accessed in `MyMethod` without setting a value.  Because it is an integer, it defaults to 0, but using a different type might lead to different (and often unpredictable) results.

## The Solution
The solution is to always initialize your properties, either during declaration or before accessing them.