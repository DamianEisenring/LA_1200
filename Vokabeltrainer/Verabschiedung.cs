using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyTrainer
{
    internal class goodbye
    {
        public static void bye()
        {
            Console.Clear();
            Console.WriteLine("Vielen dank fürs benutzen unseres Vokabeltrainers");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
