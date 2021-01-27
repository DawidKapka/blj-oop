package ch.ictbz.todolist;

import java.time.LocalDate;

public class Task {
    private String title;
    private String description;
    private LocalDate dueDate;
    private LocalDate creationDate;
    private TaskState state;
    private boolean isArchived;


    public Task(String Title, String Desc, LocalDate Due, LocalDate Creation, TaskState State) {
        title = Title;
        description = Desc;
        dueDate = Due;
        creationDate = Creation;
        state = State;
    }

    public enum TaskState {
        Todo,
        InProgress,
        Done,
        Archived
    }

    public String getTitle() {
        return title;
    }
    public void setTitle(String value) {
        title = value;
    }

    public String getDescription() {
        return description;
    }
    public void setDescription(String value) {
        description = value;
    }

    public LocalDate getDueDate() {
        return dueDate;
    }
    public void setDueDate(LocalDate value) {
        dueDate = value;
    }

    public LocalDate getCreationDate() {
        return creationDate;
    }

    public TaskState getState() {
        return state;
    }
    public void setState(TaskState value) {
        state = value;
    }
}
