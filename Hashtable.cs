using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();

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
                hashtable.Add(keyInput, valueInput);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Key already exists. Please enter a unique key.");
            }
        }

        Console.WriteLine("\nEnter a key to check if it exists in the Hashtable:");
        string keyToCheck = Console.ReadLine();
        Console.WriteLine($"Contains key '{keyToCheck}': {hashtable.ContainsKey(keyToCheck)}");

        Console.WriteLine("\nEnter a value to check if it exists in the Hashtable:");
        string valueToCheck = Console.ReadLine();
        Console.WriteLine($"Contains value '{valueToCheck}': {hashtable.ContainsValue(valueToCheck)}");

        Console.WriteLine("\nEnter a key to retrieve its value:");
        string keyToRetrieve = Console.ReadLine();
        if (hashtable.ContainsKey(keyToRetrieve))
        {
            Console.WriteLine($"Value for key '{keyToRetrieve}': {hashtable[keyToRetrieve]}");
        }
        else
        {
            Console.WriteLine("Key not found in the Hashtable.");
        }

        Console.WriteLine("\nKeys in the Hashtable:");
        foreach (var key in hashtable.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nValues in the Hashtable:");
        foreach (var value in hashtable.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("\nKey-Value pairs in the Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
