using System;
using System.Collections.Generic;
public class MyStack<T>
{
    private List<T> elements = new List<T>();
    public void Push(T item)
    {
        elements.Add(item);
    }
    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        T top = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return top;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyStack<int> intStack = new MyStack<int>();
        Console.Write("Enter integers to push onto the stack (type 'done' to stop):");
        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            if (int.TryParse(input, out int number))
            {
                intStack.Push(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer or 'done' to stop.");
            }
        }
        Console.Write("Popping elements from the integer stack: ");
        try
        {
            while (true)
            {
                Console.WriteLine(intStack.Pop());
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); 
        }

        MyStack<string> stringStack = new MyStack<string>();
        Console.Write("\nEnter strings to push onto the stack (type 'done' to stop):");
        while ((input = Console.ReadLine()) != "done")
        {
            stringStack.Push(input);
        }
        Console.Write("Popping elements from the string stack:");
        try
        {
            while (true)
            {
                Console.WriteLine(stringStack.Pop());
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); 
        }

        MyStack<double> doubleStack = new MyStack<double>();
        Console.Write("\nEnter doubles to push onto the stack (type 'done' to stop):");
        while ((input = Console.ReadLine()) != "done")
        {
            if (double.TryParse(input, out double number))
            {
                doubleStack.Push(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a double or 'done' to stop.");
            }
        }
        Console.Write("Popping elements from the double stack:");
        try
        {
            while (true)
            {
                Console.WriteLine(doubleStack.Pop());
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); 
        }
    }
}
