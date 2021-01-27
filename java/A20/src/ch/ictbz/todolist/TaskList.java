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
        tasks.remove(task);
    }
    public List<Task> search(String searchCrit) {
        List<Task> searchList = new ArrayList<Task>();
        for (Task t : tasks) {
            if (t.getTitle().contains(searchCrit)
                    || t.getDescription().contains(searchCrit)
                    || t.getDueDate().toString().contains(searchCrit)
                    || t.getCreationDate().toString().contains(searchCrit)
                    || t.getState().equals(searchCrit))
                searchList.add(t);
        }
        return searchList;
    }
    public List<Task> getTasks() {
        return tasks;
    }
}
