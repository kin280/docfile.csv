using System;
using System.IO;

class Program
{
    static void Main()
    {
        
        string filePath = "quocqia.csv";

        try
        {
            
            string[] lines = File.ReadAllLines(filePath);

            
            foreach (var line in lines)
            {
               
                string[] columns = line.Split(',');

                
                Console.WriteLine($"Country Code: {columns[4]}, Country Name: {columns[5]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
        }
    }
}
