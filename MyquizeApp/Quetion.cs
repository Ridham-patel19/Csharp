using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyquizeApp
{
    internal class Quetion
    {
        public string QuetionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectanswerIndex { get; set; }

        public Quetion(string text, string[] ans,int corr)
        {
            QuetionText = text;
            Answers = ans;
            CorrectanswerIndex = corr;
        }

        public bool Iscorrectans(int choice)
        {
            return CorrectanswerIndex == choice;
        }
    }
}
