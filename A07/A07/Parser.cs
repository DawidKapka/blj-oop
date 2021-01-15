using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07
{
    class Parser
    {
        WordTab tab;

        public Parser(WordTab wrdTab)
        {
            tab = wrdTab;
        }
        public void Parse(String text)
        {
            if (text == "")
            {
                throw new Exception("Es wurde kein Text eingegeben!");
            }
            String word = "";
            char[] charArr = text.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i].Equals(' ') || charArr[i].Equals(',') || charArr[i].Equals('.'))
                {
                    if (word != "")
                    {
                        tab.AddWord(word);
                        word = "";
                    }
                }
                else
                {
                    word += charArr[i];
                }
            }
            tab.AddWord(word);
            Console.WriteLine(word);
            
        }
    }
}
