/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simple_calculator;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;

/**
 *
 * @author MANTANI
 */
public class FXMLDocumentController implements Initializable {
    
   
    @FXML  private TextField screen;
    @FXML  private Button kdot;
    @FXML  private Button k0;
    @FXML  private Button k1;
    @FXML  private Button k2;
    @FXML  private Button k3;
    @FXML  private Button k4;
    @FXML  private Button k5;
    @FXML  private Button k6;
    @FXML  private Button k7;
    @FXML  private Button k8;
    @FXML  private Button k9;
    @FXML  private Button add;
    @FXML  private Button minus;
    @FXML  private Button mult;
    @FXML  private Button  divide;
    @FXML  private Button equal;
    @FXML  private Button delete;
    @FXML  private Button AC;
    
    
//    point constraint
    
    @FXML private void zeroClicked(ActionEvent zero){
         st=screen.getText();
        if(!st.equals("0"))
            screen.appendText("0");
    }
    @FXML private void oneClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("1");
        else
            screen.appendText("1");
    }
    @FXML private void twoClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("2");
        else
            screen.appendText("2");
    }
    @FXML private void threeClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("3");
        else
            screen.appendText("3");
    }
    @FXML private void fourClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("4");
        else
            screen.appendText("4");
    }
    @FXML private void fiveClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("5");
        else
            screen.appendText("5");
    }
    @FXML private void sixClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("6");
        else
            screen.appendText("6");
    }
    @FXML private void sevenClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("7");
        else
            screen.appendText("7");
    }
    @FXML private void eightClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("8");
        else
            screen.appendText("8");
    }
    @FXML private void nineClicked(ActionEvent zero){
         st=screen.getText();
        if(st.equals("0"))
            screen.setText("9");
        else
            screen.appendText("9");
    }
    @FXML private void dotClicked(ActionEvent zero){
         st=screen.getText();
        if(!st.contains("."))
            screen.appendText(".");
        
    }
    
    
    //Operations
    //Addition event driver
    
    @FXML private void adding(ActionEvent addition){
        st=screen.getText();
        //first read screen text
        m=Integer.parseInt(st);
        //clearing screen
        screen.clear();
        //imploying equal
        equal.setOnAction(dis->{
            st=screen.getText();
            //reading current value
            n=Integer.parseInt(st);
            //now adding the first and current values
            screen.setText(""+(m+n));
        });
    }
    @FXML private void subtraction(){
        st=screen.getText();
        m=Integer.parseInt(st);
        screen.clear();
        equal.setOnAction(sub->{
            st=screen.getText();
            screen.clear();
            n=Integer.parseInt(st);
            screen.setText(""+(m-n));
        });
    }
     @FXML private void multiplication(){
         st=screen.getText();
         m=Integer.parseInt(st);
         screen.clear();
         equal.setOnAction(mul->{
             st=screen.getText();
             screen.clear();
             n=Integer.parseInt(st);
             screen.setText(""+(m*n));
         });
     }
     
      @FXML private void division(){
          st = screen.getText();
          m=Integer.parseInt(st);
          screen.clear();
          equal.setOnAction(div->{
              st=screen.getText();
              screen.clear();
              n=Integer.parseInt(st);
              screen.setText(""+(m/n));
              
          });
      }
  
    String st;
    int m,n;
    @Override
    public void initialize(URL url, ResourceBundle rb) {
//    Assigning keys 
        
        AC.setOnAction(clear->{
            m=0;
            n=0;
            screen.clear();
        });


                    
    }    
    
    
}
