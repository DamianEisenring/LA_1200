using System;
using static VocabularyTrainer.practice;
using static VocabularyTrainer.greeting;
using static VocabularyTrainer.goodbye;
using System.Security.Principal;

namespace VocabularyTrainer
{
    class programm
    {
        static void Main(string[] args)
        {
            welcome();
            WordRequest();
            bye();
        }
    }
}