using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05
{
    class Tree
    {
        int trunkWidth;
        int trunkHeight;
        int crownHeight;
        String drawing;

        public Tree(int tWidth, int tHeight, int cHeight)
        {
            trunkWidth = tWidth;
            trunkHeight = tHeight;
            crownHeight = cHeight;
        }
        public String Drawing
        {
            get { return drawing; }
        }
        

        public void Draw()
        {
            drawing = DrawCrown() + DrawTrunk();
        }
        public String DrawCrown()
        {
            String crown = "";
            int crownWidth = 2 * crownHeight - 1;
            for (int i = 0; i < crownHeight * 2; i+= 2)
            {
                for (int k = 0; k < (crownWidth - i) / 2; k++)
                {
                    crown += "  ";
                }
                for (int j = 0; j <= i; j++)
                {
                    crown += "*";
                }
                crown += Environment.NewLine;
            }
            return crown;
        }
        public String DrawTrunk()
        {
            String trunk = "";
            int crownWidth = 2 * crownHeight - 1;
            for (int i = 0; i < trunkHeight; i++)
            {
                for (int k = 1; k <= (crownWidth - trunkWidth) / 2; k++)
                {
                    trunk += "  ";
                }
                for (int j = 0; j < trunkWidth; j++)
                {
                    trunk += "*";
                }
                trunk += Environment.NewLine;
            }
            return trunk;
        }
    }
}
