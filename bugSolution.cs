public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        try
        {
            int z = x / y; 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero encountered.");
            // Handle the exception appropriately, e.g., log the error, display a message to the user, or return a default value.
        }
    }
}