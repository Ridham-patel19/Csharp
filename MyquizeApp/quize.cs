using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyquizeApp
{
    internal class quize
    {
        private Quetion[] quetions;
        private int _score;

        public quize(Quetion[] quetions)
        {
            this.quetions = quetions;
            _score = 0;
        }

        public void StartQuize()
        {
            Console.WriteLine("Welcome to the quize");
            int CurrentQuetion = 1;

            foreach (Quetion quetion in quetions)
            {
                Console.WriteLine($"Quetion {CurrentQuetion++}");
                display(quetion);
                int userchoice = Getuserchoice();
                if (quetion.Iscorrectans(userchoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else 
                {
                    Console.WriteLine($"your answer is wrong .  the correct amswer is {quetion.Answers[quetion.CorrectanswerIndex]}");
                }

            }
            DisplayeResult();
        }

        private void DisplayeResult()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("#                    Result                     #");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine($"your score is {_score} out of quetion {quetions.Length}");

            if (_score == quetions.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Excellent");
                Console.ResetColor();
            }
        }

        private void display(Quetion quetion)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("#                    Quetion                    #");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine(quetion.QuetionText);
           
            for(int i = 0; i < quetion.Answers.Length; i++)
            {
                //it will give cyan color to console
                Console.ForegroundColor = ConsoleColor.Cyan;
                //it will only print text in single line not in next lline
                Console.Write("   ");
                //it will reset back to normal color
                Console.Write(i + 1);
                Console.ResetColor();
                //it will print every text in new line
                Console.WriteLine($". {quetion.Answers[i]}");
            }

            

        }

        private int Getuserchoice()
        {
            Console.Write("please enter your choice: ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.Write("please enter the valid number: ");  
                input = Console.ReadLine();
            }
            return choice-1;//cuz user will enter 1 to 4 but we have manage that in write index 
        }
    }
}
