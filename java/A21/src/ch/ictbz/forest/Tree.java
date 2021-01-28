package ch.ictbz.forest;

public class Tree extends ForestPart {
    private String sign = "T";
    private boolean isBurning = false;

    public String getSign() {
        return sign;
    }
    public void setBurning(boolean value) {
        isBurning = value;
    }
    public boolean getBurning() {
        return isBurning;
    }

    public void burn() {
        if (isBurning) {
            if (sign.equals("T"))
                sign = "F";
            else if (sign.equals("F"))
                sign = "f";

        }
    }
}
