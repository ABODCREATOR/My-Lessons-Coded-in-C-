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
            string initialContent = "Hello Every One I'm Learning C# Text Files";

            // Creates a Text File if not Exists and Over Write The Whole txtfile Content
            File.WriteAllText("yourpath\\log.txt", initialContent); 
            Console.WriteLine("Created First File In Write Mode");


            // Appends the Text in the current text file and doesn't overwrite the whole
            // content in the text file
            File.AppendAllText("yourpath\\log.txt",
            "Another Line Appended in The File");

            
            Console.WriteLine("Another Line is Appended in the File : \n");
            Console.ReadKey();
        }
    }
}
