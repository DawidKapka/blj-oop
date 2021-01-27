package ch.ictbz.todolist;

import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.stage.Stage;

import java.time.LocalDate;

public class EditWindowController {
    @FXML
    private TextField titleBox;
    @FXML
    private TextArea descBox;
    @FXML
    private Label crDateLabel;
    @FXML
    private DatePicker dueDatePicker;
    @FXML
    private ChoiceBox stateCmbBox;
    @FXML
    private Button saveBtn;


    private Task selectedTask;
    void initData(Task t) {
        selectedTask = t;
        titleBox.setText(t.getTitle());
        descBox.setText(t.getDescription());
        crDateLabel.setText(t.getCreationDate().toString());
        dueDatePicker.setValue(t.getDueDate());
        stateCmbBox.getItems().add(Task.TaskState.Todo);
        stateCmbBox.getItems().add(Task.TaskState.InProgress);
        stateCmbBox.getItems().add(Task.TaskState.Done);
        stateCmbBox.getItems().add(Task.TaskState.Archived);
        stateCmbBox.setValue(t.getState());
    }
    @FXML
    private void saveBtn_OnClick() {
        try{
            if (titleBox.getText().isEmpty())
                throw new RuntimeException("Invalid Title!");
            if (dueDatePicker.getValue().isBefore(LocalDate.now()) || dueDatePicker.getValue().isEqual(LocalDate.now()))
                throw new RuntimeException("Invalid Due Date!");
            selectedTask.setTitle(titleBox.getText());
            selectedTask.setDescription(descBox.getText());
            selectedTask.setDueDate(dueDatePicker.getValue());
            selectedTask.setState((Task.TaskState)stateCmbBox.getValue());
            Stage stage = (Stage)saveBtn.getScene().getWindow();
            stage.close();
        }
        catch (RuntimeException ex) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(ex.getMessage());
            alert.showAndWait();
        }
    }
}
