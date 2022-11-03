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
             if (!File.Exists("users.txt"))
                File.Create("users.txt").Close();

            string[][] users = loadData("users.txt");

            foreach (var user in users)
            {
                Console.WriteLine("-----");
                Console.WriteLine("Vorname: " + user[0]);
                Console.WriteLine("Nachname: " + user[1]);
                Console.WriteLine("-----");
            }

            while (true)
            {

            }
        }

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
}
