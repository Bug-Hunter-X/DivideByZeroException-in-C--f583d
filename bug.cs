public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        int z = x / y; // This will throw a DivideByZeroException
    }
}