using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Menu
{
    public class Question
    {
        public string Sentence { get; set; }
        public bool Answer { get; set; }

        public Question(string sentence, bool answer)
        {
            Sentence = sentence;
            Answer = answer;
        }
    }
}
