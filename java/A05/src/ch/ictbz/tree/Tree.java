package ch.ictbz.tree;

public class Tree {
    private int trunkWidth;
    private int trunkHeight;
    private int crownHeight;
    private String drawing = "";

    public Tree(int tWidth, int tHeight, int cHeight) {
        trunkWidth = tWidth;
        trunkHeight = tHeight;
        crownHeight = cHeight;
    }

    public void draw() {
        //draw crown
        int crownWidth = 2 * crownHeight - 1;
        for (int i = 0; i < crownHeight * 2; i+= 2)
        {
            for (int k = 0; k < (crownWidth - i) / 2; k++)
            {
                drawing += " ";
            }
            for (int j = 0; j <= i; j++)
            {
                drawing += "*";
            }
            drawing += System.lineSeparator();
        }
        //draw trunk
        for (int i = 0; i < trunkHeight; i++) {
            for (int k = 1; k <= (crownWidth - trunkWidth) / 2; k++)
            {
                drawing += " ";
            }
            for (int j = 0; j < trunkWidth; j++) {
                drawing += "*";
            }
            drawing += System.lineSeparator();
        }
    }

    public String getDrawing() {
        return drawing;
    }

}
