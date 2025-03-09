using System;

public interface IOutput
{
    void Show();  
    void Show(string info);  
}

// MyArray class implementing the IOutput interface
public class MyArray : IOutput
{
    private int[] _array;  

    // Constructor to initialize the array
    public MyArray(int[] array)
    {
        _array = array;
    }

    // Implementation of the Show() method - displays the array elements
    public void Show()
    {
        foreach (var item in _array)
        {
            Console.WriteLine(item);
        }
    }

    // Implementation of the Show(string info) method - displays the array elements and additional message
    public void Show(string info)
    {
        Console.WriteLine(info);
        foreach (var item in _array)
        {
            Console.WriteLine(item);
        }
    }
}

// Main program for testing
class Program
{
    static void Main()
    {
     
        int[] numbers = { 1, 2, 3, 4, 5 };
        MyArray myArray = new MyArray(numbers);

        
        Console.WriteLine("Calling Show() without parameters:");
        myArray.Show();

        
        Console.WriteLine("\nCalling Show() with a message:");
        myArray.Show("This is an array of numbers:");
    }
}