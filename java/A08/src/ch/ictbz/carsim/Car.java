package ch.ictbz.carsim;

public class Car {
    private String brand;
    private int ps;
    private int speed;
    private int gear;
    private boolean isEngineStarted;

    public Car(String Brand, int PS) {
        brand = Brand;
        ps = PS;
    }
    public String getBrand() {
        return brand;
    }
    public int getPs() {
        return ps;
    }
    public int getSpeed() {
        return speed;
    }
    public int getGear() {
        return gear;
    }

    public void startEngine() {

    }
    public void stopEngine() {

    }
    public void accelerate() {

    }
    public void slowDown() {

    }
    public void useHorn() {

    }

}

