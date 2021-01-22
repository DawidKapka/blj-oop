package ch.ictbz.tree;

import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.fxml.FXML;
import javafx.scene.control.*;

public class Controller {
    @FXML
    private Button drawBtn;
    @FXML
    private TextField tWidthBox;
    @FXML
    private TextField tHeightBox;
    @FXML
    private TextField cHeightBox;
    @FXML
    private TextArea resultBox;

    @FXML
    private void drawBtn_onClick() {
        Tree tree = new Tree(Integer.parseInt(tWidthBox.getText()), Integer.parseInt(tHeightBox.getText()), Integer.parseInt(cHeightBox.getText()));
        tree.draw();
        resultBox.setText(tree.getDrawing());

    }
    @FXML
    private void tWidthBox_onKeyTyped() {
        tWidthBox.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observable, String oldValue, String newValue) {
                if (!newValue.matches("\\d{0,2}")) {
                    tWidthBox.setText(oldValue);
                }
            }
        });
    }
    @FXML
    private void tHeightBox_onKeyTyped() {
        tHeightBox.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observable, String oldValue, String newValue) {
                if (!newValue.matches("\\d{0,2}")) {
                    tHeightBox.setText(oldValue);
                }
            }
        });
    }
    @FXML
    private void cHeightBox_onKeyTyped() {
        cHeightBox.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observable, String oldValue, String newValue) {
                if (!newValue.matches("\\d{0,2}")) {
                    cHeightBox.setText(oldValue);
                }
            }
        });
    }
}
