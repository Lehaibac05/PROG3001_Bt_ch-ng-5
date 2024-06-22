using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<object, object> dictionary = new Dictionary<object, object>();

        Console.WriteLine("Enter key-value pairs (type 'done' to stop):");
        while (true)
        {
            Console.Write("Enter key: ");
            string keyInput = Console.ReadLine();
            if (keyInput.ToLower() == "done")
            {
                break;
            }

            Console.Write("Enter value: ");
            string valueInput = Console.ReadLine();
            if (valueInput.ToLower() == "done")
            {
                break;
            }

            try
            {
                dictionary.Add(keyInput, valueInput);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Key already exists. Please enter a unique key.");
            }
        }

        Console.WriteLine("\nEnter a key to check if it exists in the Dictionary:");
        string keyToCheck = Console.ReadLine();
        Console.WriteLine($"Contains key '{keyToCheck}': {dictionary.ContainsKey(keyToCheck)}");

        Console.WriteLine("\nEnter a key to retrieve its value:");
        string keyToRetrieve = Console.ReadLine();
        if (dictionary.TryGetValue(keyToRetrieve, out object value))
        {
            Console.WriteLine($"Value for key '{keyToRetrieve}': {value}");
        }
        else
        {
            Console.WriteLine("Key not found in the Dictionary.");
        }

        Console.WriteLine("\nKey-Value pairs in the Dictionary:");
        foreach (KeyValuePair<object, object> entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
