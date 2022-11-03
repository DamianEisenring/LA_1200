using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokabeltrainer
{
    public class XyClass
    {
        public static void Wörterabfrage()
        {
          int i = 0;
            int l = 0; 
           List<string> FslWörter = new List<string>();

            try
            {
                if (!File.Exists("users.txt"))
                    File.Create("users.txt").Close();

                string[][] users = loadData("users.txt");
                

                foreach (var user in users)
                {
                    Console.WriteLine("-----");
                    Console.WriteLine("Deutscheswort: " + user[0]);
                    Console.Write("Fremdwort: ");
                    string eingabe = Console.ReadLine();
                    if (eingabe == user[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Richtig");
                        Console.ForegroundColor = ConsoleColor.White;                        
                        Console.ReadKey();
                        i++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Falsch");
                        Console.ForegroundColor = ConsoleColor.White;                    
                        Console.ReadKey();
                        l++;
                        FslWörter.Add(user[1]);

                    }
                    
                }
                Console.WriteLine("Richtige: "+ i + " Falsche: "+ l);
                Console.ReadKey();



                foreach(var falsch in FslWörter)
                {
                    Console.WriteLine(falsch);                    
                }
                Console.ReadKey();



                static string[][] loadData(string path)
                {
                    string[] data = File.ReadAllLines(path);

                    string[][] users = new string[data.Length][];

                    for (int i = 0; i < data.Length; i++)
                    {
                        users[i] = data[i].Split(';');
                    }

                    return users;
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }

        }

    }
}
