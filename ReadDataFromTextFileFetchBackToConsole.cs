using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.ExceptionServices;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "Ex2_File.txt";
            List<string> Userslist = new List<string>
            {
                "Abdallah1234" , "Mohamed24e6" , "Wael236T" , "Fatma2354"
            };

            // Saved the List Of Users in a text File
            File.WriteAllLines(filepath, Userslist);
            Console.WriteLine("Users Saved Successfully.");
            
            // Here's an Array Of String That Read all lines from the text file 
            // and back it to the console that you can read it in your console
            string[] loadedlines = File.ReadAllLines(filepath);

      
            // Iteration Through Users in the Text File
            for(int i = 0; i < loadedlines.Length; i++)
                Console.WriteLine($"User {i + 1} is {loadedlines[i]}");
            Console.ReadKey();
        }
    }
}
