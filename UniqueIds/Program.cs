using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    //HashSet
    static void Main()
    {
        string inputFile = "C:\\Users\\user\\Desktop\\Pendings.txt";
        string outputFile = "C:\\Users\\user\\Desktop\\UniquePendings.txt";
        HashSet<string> uniqueNumbers = ReadUniqueNumbers(inputFile);
        WriteNumbersToFile(uniqueNumbers, outputFile);
        Console.WriteLine("Уникальные номера были записаны в файл: " + outputFile);
    }

    static HashSet<string> ReadUniqueNumbers(string filePath)
    {
        HashSet<string> uniqueNumbers = new HashSet<string>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    uniqueNumbers.Add(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка чтения файла: " + ex.Message);
        }

        return uniqueNumbers;
    }

    static void WriteNumbersToFile(HashSet<string> numbers, string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка записи файла: " + ex.Message);
        }
    }
}

