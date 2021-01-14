using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07
{
    class WordTab
    {
        String[] allWords = new String[1];
        public void AddWord(String word)
        {
            Array.Resize(ref allWords, allWords.Length + 1);
            for (int i = 0; i < allWords.Length; i++)
            {
                if (allWords[i] == null)
                {
                    allWords[i] = word;
                    break;
                }
            }
        }
        public String GetTab()
        {
            CountWords();
            return "1";
        }
        void CountWords()
        {
            int[] count = new int[3];
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < allWords.Length; j++)
                {
                    if (allWords[i] == allWords[j])
                    {
                        count[i]++;
                    }
                }
                
            }
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);
            }

        }
        
    }

}
