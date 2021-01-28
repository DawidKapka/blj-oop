package ch.ictbz.carsim;

import com.sun.org.apache.bcel.internal.generic.IF_ACMPEQ;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;

import java.io.File;

public class Car {
    private String brand;
    private int ps;
    private int speed;
    private int gear = 1;
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
    public boolean getEngineState() {
        return isEngineStarted;
    }

    public void startEngine() {
        isEngineStarted = true;
    }
    public void stopEngine() {
        isEngineStarted = false;
    }
    public void accelerate() {
        if (speed <= (ps + 100) - (ps / 14)) {
            speed += ps / 14;
        }
        else if (speed >= (ps + 100) - (ps / 14)) {
            speed = ps + 100;
        }
    }
    public void slowDown() {
        if (speed > ps / 10) {
            speed -= ps / 10;
        }
        else if (speed <= ps / 10) {
            speed = 0;
        }
    }
    public void useHorn() {
        Media horn = new Media(new File("sounds/horn.wav").toURI().toString());
        MediaPlayer hornPlayer = new MediaPlayer(horn);
        hornPlayer.play();
    }
    public void changeGear() {
        if (speed <= 10)
            gear = 1;
        if (speed > 10 && speed <= 20)
            gear = 2;
        if (speed > 20 && speed <= 40)
            gear = 3;
        if (speed > 40 && speed <= 70)
            gear = 4;
        if (speed > 70 && speed <= 100)
            gear = 5;
        if (speed > 100)
            gear = 6;
    }

}

