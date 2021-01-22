package ch.ictbz.todolist;

import javafx.fxml.FXML;
import javafx.stage.Stage;
import javafx.scene.control.*;
import java.time.LocalDate;

public class AddWindowController {
    @FXML
    private Button cancelBtn;
    @FXML
    private Button saveBtn;
    @FXML
    private TextField titleField;
    @FXML
    private TextArea descField;
    @FXML
    private DatePicker dueDatePicker;


    @FXML
    private void cancelBtn_onClick() {
        Stage stage = (Stage)cancelBtn.getScene().getWindow();
        stage.close();
    }
    @FXML
    private void saveBtn_onClick() {
        try {
            if (titleField.getText().isEmpty())
                throw new RuntimeException("Invalid Title!");
            if (dueDatePicker.getValue() == null || dueDatePicker.getValue().isBefore(LocalDate.now()) || dueDatePicker.getValue().isEqual(LocalDate.now()))
                throw new RuntimeException("Invalid Due Date!");
            Task task = new Task(titleField.getText(), descField.getText(), dueDatePicker.getValue(), LocalDate.now(), Task.TaskState.Todo);
            MainWindowController.tList.add(task);
            Stage stage = (Stage)saveBtn.getScene().getWindow();
            stage.close();
        }
        catch (RuntimeException ex) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(ex.toString());
            alert.showAndWait();
        }



    }

}
