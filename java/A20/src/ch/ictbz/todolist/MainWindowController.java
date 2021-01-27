package ch.ictbz.todolist;

import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.stage.Stage;

import java.io.IOException;
import java.util.List;
import java.util.Optional;

public class MainWindowController {
    @FXML
    private ListView taskList;
    public static TaskList tList = new TaskList();
    private List<Task> searchList = tList.getTasks();
    private boolean isArchive = false;
    private boolean isSearch = false;
    @FXML
    private Button archBtn;
    @FXML
    private Button searchBtn;
    @FXML
    private TextField searchField;
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
    public void updateTable() {
        taskList.getItems().clear();
        for (Task t : searchList) {
            if (!t.getState().equals(Task.TaskState.Archived))
                taskList.getItems().add(t.getTitle());
            }


    }

    private void updateArchive() {
        taskList.getItems().clear();
        for (Task t : searchList) {
            if (t.getState().equals(Task.TaskState.Archived))
                taskList.getItems().add(t.getTitle());
            }

    }
    @FXML
    private void archBtn_OnClick() {
        if (!isArchive) {
            isArchive = true;
            archBtn.setText("Show Active");
            updateArchive();
        }
        else {
            isArchive = false;
            archBtn.setText("Show Archive");
            updateTable();
        }
    }
    public void editBtn_OnClick() {
        try {
            Task selectedTask = null;
            for (Task t : tList.getTasks()) {
                if (t.getTitle().equals(taskList.getSelectionModel().getSelectedItem()))
                    selectedTask = t;
            }
            if (selectedTask != null) {
                FXMLLoader fxmlLoader = new FXMLLoader();
                fxmlLoader.setLocation(getClass().getResource("EditWindow.fxml"));
                Scene scene = new Scene(fxmlLoader.load(), 350, 400);
                Stage stage = new Stage();
                stage.setTitle("Edit");
                stage.setScene(scene);
                EditWindowController controller = fxmlLoader.getController();
                controller.initData(selectedTask);
                stage.show();
            }
        }
        catch (IOException e){
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText("Error");
            alert.setContentText(e.getMessage());
            alert.showAndWait();
        }
    }
    @FXML
    private void delBtn_OnClick() {
        Task selectedTask = null;
        for (Task t : tList.getTasks()) {
            if (t.getTitle().equals(taskList.getSelectionModel().getSelectedItem()))
                selectedTask = t;
        }
        if (selectedTask != null) {
            Alert alert = new Alert(Alert.AlertType.CONFIRMATION);
            alert.setHeaderText("Delete '" + selectedTask.getTitle() + "'?");
            Optional<ButtonType> result = alert.showAndWait();
            if (result.get() == ButtonType.OK) {
                tList.remove(selectedTask);
            }
            else {
                alert.close();
            }
        }
    }
    @FXML
    private void searchBtn_OnClick() {
        try {
            if (!isSearch) {
                if (searchField.getText().equals(""))
                    throw new RuntimeException("No Search Criteria!");
                searchList = tList.search(searchField.getText());
                isSearch = true;
                searchBtn.setText("Show All");
            }
            else {
                searchList = tList.getTasks();
                isSearch = false;
                searchBtn.setText("Search");
            }
            updateTable();

        }
        catch (RuntimeException ex) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setHeaderText(ex.getMessage());
            alert.showAndWait();
        }

    }



}
