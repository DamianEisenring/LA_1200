using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vokabeltrainer
{
    internal class Begrüssung
    {
        public static void Willkommen()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Herzlich Willkommen");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        
            Console.WriteLine("In diesem Programm können sie Vokabeln lernen. Dafür wurde im Hintergrund eine Txt-Datei erstellt(users.txt).\nBitte öffnen sie Datei, falls sie den zu lernden Wortschatz ändern möchten gehen sie bitte in diese Datei. \n Für das müssen sie die Vokabel so eingeben: Wort in angewonter Sprache;Wort in Fremdsprache (Guten Tag;Bonjour)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
