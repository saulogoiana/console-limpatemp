using System;
using System.IO;
using System.Reflection.Metadata;

namespace LimpaTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Limpa Temp";

                string tempDirectory = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\";

                int qtdFiles = Directory.GetFiles(tempDirectory).Length + 
                    Directory.GetDirectories(tempDirectory).Length;

                Console.WriteLine(qtdFiles + " Temporary files and folders in "+tempDirectory);
                Console.Write("\nDelete? ( Y/ N/ Default Y): ");
                switch (Console.ReadLine().ToUpper()) 
                {
                    case "N":
                        break;

                    default:
                        try
                        {
                            Directory.Delete(tempDirectory,true);
                        }
                        catch(Exception ex)
                        {
                            //Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("Cleaned! Hope You Enjoied!");

                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
