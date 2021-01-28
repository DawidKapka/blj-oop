package samples.javafx.usercontrols;

import ch.ictbz.lib.ui.UserControl;
import javafx.fxml.FXML;
import javafx.scene.shape.Rectangle;

/**
 * Created by nuu on 12.01.2017.
 */
public class GraphicDisplay extends UserControl {
    // maximum height of the temperature rectangle, 100 = 50°
    final int MAX = 100;
    // minimum height of the temperature rectangle, 0 = 0°
    final int MIN = 0;

    @FXML
    private Rectangle temperatureRectangle;

    public GraphicDisplay(){
        temperatureRectangle.setHeight(0);
        temperatureRectangle.setLayoutY(152);
    }
}
