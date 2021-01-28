package ch.ictbz.forest;

import javafx.animation.Animation;
import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.fxml.FXML;
import javafx.scene.control.*;
import javafx.util.Duration;

import java.sql.Time;
import java.util.List;
import java.util.Random;

public class MainWindowController {
    @FXML private TextField widthBox;
    @FXML private TextField heightBox;
    @FXML private TextField growthBox;
    @FXML private TextField inflBox;
    @FXML private TextArea simBox;
    @FXML private Button startBtn;
    Timeline simulation;

    @FXML private void startSim() {
        //restart
        if (simulation != null)
            simulation.stop();
        simBox.setText("");

        //init
        Forest forest = new Forest(Integer.parseInt(widthBox.getText()), Integer.parseInt(heightBox.getText()));
        int growthRate = Integer.valueOf(growthBox.getText());
        int inflRate = Integer.valueOf(inflBox.getText());
        simulation = new Timeline(new KeyFrame(Duration.millis(1500), actionEvent -> {
            List<ForestPart> forestList = forest.getForestList();
            for (int i = 0; i < forestList.size(); i++) {
                // get random number for %
                Random random = new Random();
                int randomPrc = random.nextInt(101);
                boolean justGrew = false;

                //grow new Tree
                if (forestList.get(i) instanceof Humus && randomPrc < growthRate) {
                    forestList.set(i, new Tree());
                    randomPrc = inflRate + 1;
                    justGrew = true;
                }

                //change to humus
                if (forestList.get(i).getSign().equals("f"))
                    forestList.set(i, new Humus());

                //check for burning neighbour trees && inflame
                if (!justGrew) {
                    if (i != 0)
                        if (forestList.get(i-1) instanceof Tree && ((Tree) forestList.get(i-1)).getBurning() == true)
                            if (forestList.get(i) instanceof Tree)
                                ((Tree) forestList.get(i)).setBurning(true);
                    if (i != forestList.size()-1)
                        if (forestList.get(i+1) instanceof Tree && ((Tree) forestList.get(i+1)).getBurning() == true)
                            if (forestList.get(i) instanceof Tree)
                                ((Tree) forestList.get(i)).setBurning(true);


                    //inflame (%) and burn tree
                    if (forestList.get(i) instanceof Tree && randomPrc < inflRate) {
                        ((Tree) forestList.get(i)).setBurning(true);
                        ((Tree) forestList.get(i)).burn();
                    }
                    else if (forestList.get(i) instanceof Tree)
                        ((Tree) forestList.get(i)).burn();

                }

            }
            simBox.setText("");
            simBox.setText(forest.getForest());


        }));
        forest.initForest();
        simBox.setText(forest.getForest());
        simulation.setCycleCount(Animation.INDEFINITE);
        simulation.play();
    }

    @FXML private void checkWidthBox() {
        widthBox.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observable, String oldValue, String newValue) {
                if (!newValue.matches("\\d{0,2}")) {
                    widthBox.setText(oldValue);
                }
            }
        });

    }
    @FXML private void checkHeightBox() {
        heightBox.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observable, String oldValue, String newValue) {
                if (!newValue.matches("\\d{0,2}")) {
                    heightBox.setText(oldValue);
                }
            }
        });

    }
    @FXML private void checkGrowthBox() {
        growthBox.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observable, String oldValue, String newValue) {
                if (!newValue.matches("\\d{0,2}")) {
                    growthBox.setText(oldValue);
                }
            }
        });

    }
    @FXML private void checkInflBox() {
        inflBox.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observable, String oldValue, String newValue) {
                if (!newValue.matches("\\d{0,2}")) {
                    inflBox.setText(oldValue);
                }
            }
        });

    }
}
