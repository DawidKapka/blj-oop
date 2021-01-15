using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            String table = String.Format("{0,-20} {1,20}", "Wort", "Anzahl");
            var groups = allWords.GroupBy(v => v);
            foreach (var group in groups)
            {
                table += Environment.NewLine;
                String line = String.Format("{0,-20} {1,20}", group.Key, group.Count());
                table += line;
            }
            table = table.Substring(0, table.Length-3);
            return table;

        }
        public void PrintTab(String table, TextBox outputBox)
        {
            outputBox.Text = table;
        }
        
    }
}
