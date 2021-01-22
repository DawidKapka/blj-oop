package ch.ictbz.square_area;

import javafx.fxml.FXML;
import javafx.scene.control.Alert;
import javafx.scene.control.TextArea;

public class Controller {
    @FXML
    private TextArea widthBox;
    @FXML
    private TextArea heightBox;
    @FXML
    private TextArea resultBox;

    @FXML
    private void onButtonClick() {
        int width = Integer.parseInt(widthBox.getText());
        int height = Integer.parseInt(heightBox.getText());

        resultBox.setText(String.valueOf(width * height));
    }
}
