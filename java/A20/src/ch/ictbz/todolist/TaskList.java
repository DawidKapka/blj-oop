package ch.ictbz.todolist;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;

import java.time.LocalDate;
import java.util.*;

public class TaskList {
    private List<Task> tasks = new ArrayList<Task>();

    public void add(Task task){
        tasks.add(task);
    }
    public void remove(Task task) {

    }
    public List<Task> search(String searchCrit) {
        return tasks;
    }
    public List<Task> getTasks() {
        return tasks;
    }
}
