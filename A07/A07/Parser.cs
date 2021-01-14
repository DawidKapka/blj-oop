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
        public String[] Parse(String text)
        {
            String[] words = new string[1];
            text.ToCharArray();
            int j = 1;

                for (int i = 0; i < text.Length; i++)
                {
                    if (!text[i].Equals(" "))
                    {
                        Array.Resize(ref words, j + 1);
                        words[j] += text[i];
                    }
                    else
                    {
                        j++;
                    }

                }
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            return words;
        }
    }
}
