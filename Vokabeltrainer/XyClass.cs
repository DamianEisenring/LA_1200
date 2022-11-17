using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    public class practice
    {
        public static void WordRequest()
        {
            int wordsRight = 0;
            int wordsWrong = 0;
            List<string> FslWörter = new List<string>();
            string userInput;

            try
            {
                do
                {
                    if (!File.Exists("users.txt"))
                        File.Create("users.txt").Close();

                    string[][] users = loadData("users.txt");


                    foreach (var user in users)
                    {
                        Console.WriteLine("-----");
                        Console.WriteLine("Deutscheswort: " + user[0]);
                        Console.Write("Fremdwort: ");
                        string input = Console.ReadLine();
                        if (input == user[1])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Richtig");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            wordsRight++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Falsch");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            wordsWrong++;
                            FslWörter.Add(user[1]);

                        }

                    }
                    Console.WriteLine("Richtige: " + wordsRight + " Falsche: " + wordsWrong);


                    Console.WriteLine("Hier sind die immer noch zu lernenden Wörter:");

                    foreach (var wrong in FslWörter)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(wrong);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("-----------");
                    do
                    {
                        Console.Write("Möchtest du es nochmal Lernen?[Ja/Nein]");
                        userInput = Console.ReadLine();
                        if (userInput != "Ja" || userInput != "Nein")
                        {
                            Console.WriteLine("Sie müssen Ja oder Nein eingeben");   
                        }

                    } while (userInput != "Ja" && userInput != "Nein");
                } while (userInput == "Ja");




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
