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
            String word = "";
            char[] charArr = text.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (!charArr[i].Equals(' '))
                {
                    word += charArr[i];
                }
                else
                {
                    tab.AddWord(word);
                    word = "";
                }
            }
            tab.AddWord(word);
            word = "";
            String table = tab.GetTab();
        }
    }
}
