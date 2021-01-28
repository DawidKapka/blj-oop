package ch.ictbz.forest;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Forest {
    private int width;
    private int height;
    private List<ForestPart> forest = new ArrayList<ForestPart>();
    private String forestString = "";

    public Forest(int Width, int Height) {
        width = Width;
        height = Height;
    }
    public void initForest() {
        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width; j++) {
                Random random = new Random();
                int randomInt = random.nextInt(3);
                if (randomInt == 0)
                    forest.add(new Tree());
                else if (randomInt == 1)
                    forest.add(new Stone());
                else
                    forest.add(new Humus());
            }
        }
    }
    public String getForest() {
        forestString = "";
        int maxWidth = 0;
        for (ForestPart part : forest) {
            forestString += part.getSign();
            maxWidth++;
            if (maxWidth == width) {
                forestString += System.lineSeparator();
                maxWidth = 0;
            }
        }
        return forestString;
    }
    public List<ForestPart> getForestList() {
        return forest;
    }



}
