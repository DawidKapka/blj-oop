package ch.ictbz.carsim;

import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.util.StringConverter;

public class MainWindowController {
    @FXML private ChoiceBox carCmbBox;
    @FXML private TextField speedBox;
    @FXML private TextField gearBox;
    @FXML private Label psLabel;
    @FXML private TextField engineLight;

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
    }

    @FXML public void onSelectedCar() {
        Car selectedCar = (Car)carCmbBox.getSelectionModel().getSelectedItem();
        psLabel.setText(selectedCar.getPs() + " PS");
    }

}
