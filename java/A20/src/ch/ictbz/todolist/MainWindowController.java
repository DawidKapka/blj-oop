package ch.ictbz.todolist;

import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.stage.Stage;

import java.io.IOException;

public class MainWindowController {
    @FXML
    private ListView taskList;
    public static TaskList tList = new TaskList();
    @FXML
    private void newBtn_onClick() {
        try {
            FXMLLoader fxmlLoader = new FXMLLoader();
            fxmlLoader.setLocation(getClass().getResource("AddWindow.fxml"));
            Scene scene = new Scene(fxmlLoader.load(), 400, 300);
            Stage stage = new Stage();
            stage.setTitle("New Task");
            stage.setScene(scene);
            stage.show();
        }
        catch (IOException e){
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText("Error");
            alert.setContentText(e.getMessage());
            alert.showAndWait();
        }

    }
    @FXML
    public void UpdateTable() {
        taskList.getItems().clear();
        for (Task t : tList.getTasks()) {
            taskList.getItems().add(t.getTitle());
        }
    }

}
