package samples.javafx.usercontrols;

import  ch.ictbz.lib.ui.UserControl;
import javafx.fxml.FXML;
import javafx.scene.control.Label;

/**
 * Created by nuu on 12.01.2017.
 */
public class NumericDisplay extends UserControl {

    @FXML
    private Label temperatureLabel;

    public NumericDisplay(){
        temperatureLabel.setText("0");
    }
}
