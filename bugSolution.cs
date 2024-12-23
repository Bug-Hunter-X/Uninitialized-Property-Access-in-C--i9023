public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize during declaration

    public void MyMethod()
    {
        // Initialize before usage
        MyProperty = 10; 
        Console.WriteLine(MyProperty); 
    }
}