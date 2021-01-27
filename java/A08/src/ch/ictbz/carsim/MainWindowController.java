package ch.ictbz.carsim;

import javafx.animation.Animation;
import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.util.Duration;
import javafx.util.StringConverter;

import java.util.concurrent.TimeUnit;

public class MainWindowController {
    @FXML private ChoiceBox carCmbBox;
    @FXML private TextField speedBox;
    @FXML private TextField gearBox;
    @FXML private Label psLabel;
    @FXML private TextField engineLight;
    @FXML private Button engSwitch;
    @FXML private Button beepBtn;
    @FXML private Button breakBtn;
    @FXML private Button accBtn;
    Car selectedCar = null;

    Timeline speedTimeLine = new Timeline(new KeyFrame(Duration.millis(500), actionEvent -> {
        selectedCar.accelerate();
        speedBox.setText(String.valueOf(selectedCar.getSpeed()));
        selectedCar.changeGear();
        gearBox.setText(String.valueOf(selectedCar.getGear()));
    }));
    Timeline breakTimeLine = new Timeline(new KeyFrame(Duration.millis(500), actionEvent -> {
        selectedCar.slowDown();
        speedBox.setText(String.valueOf(selectedCar.getSpeed()));
        selectedCar.changeGear();
        gearBox.setText(String.valueOf(selectedCar.getGear()));
    }));

    public void initialize() {
        carCmbBox.getItems().add(new Car("Opel", 90));
        carCmbBox.getItems().add(new Car("Porsche", 250));
        carCmbBox.getItems().add(new Car("Ferrari", 370));
        carCmbBox.setConverter(new StringConverter<Car>() {
            @Override
            public String toString(Car car) {
                return car.getBrand();
            }
            @Override
            public Car fromString(String str) {
                return null;
            }

        });
        speedTimeLine.setCycleCount(Animation.INDEFINITE);
        breakTimeLine.setCycleCount(Animation.INDEFINITE);
        accBtn.armedProperty().addListener(new ChangeListener<Boolean>() {
            @Override
            public void changed(ObservableValue<? extends Boolean> observable, Boolean oldValue, Boolean newValue) {
                if (newValue)
                    speedTimeLine.play();
                else
                    speedTimeLine.stop();
            }
        });
        breakBtn.armedProperty().addListener(new ChangeListener<Boolean>() {
            @Override
            public void changed(ObservableValue<? extends Boolean> observable, Boolean oldValue, Boolean newValue) {
                if (newValue)
                    breakTimeLine.play();
                else
                    breakTimeLine.stop();
            }
        });

    }
    @FXML public void onSelectedCar() {
        selectedCar = (Car)carCmbBox.getSelectionModel().getSelectedItem();
        psLabel.setText(selectedCar.getPs() + " PS");
        speedBox.setText(String.valueOf(selectedCar.getSpeed()));
        gearBox.setText(String.valueOf(selectedCar.getGear()));
        engSwitch.setDisable(false);
        checkEngineState();
    }
    @FXML private void switchEngine() {
        if (!selectedCar.getEngineState()) {
            selectedCar.startEngine();
            checkEngineState();
        }
        else {
            if (selectedCar.getSpeed() == 0) {
                selectedCar.stopEngine();
                checkEngineState();
            }

        }
    }
    private void checkEngineState() {
        if (selectedCar.getEngineState()) {
            beepBtn.setDisable(false);
            breakBtn.setDisable(false);
            accBtn.setDisable(false);
            engineLight.setStyle("-fx-background-color: #51ff5a");
        }
        else {
            beepBtn.setDisable(true);
            breakBtn.setDisable(true);
            accBtn.setDisable(true);
            engineLight.setStyle("-fx-background-color: #8c8c8c");
        }
    }



}
