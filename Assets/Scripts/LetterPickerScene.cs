using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterPickerScene : MonoBehaviour
{
    public static int letter_to_focus = 0;
    
   public void pickLetter (int val)
    {

        if (val == 0)
        {
           
            letter_to_focus = 0;
            
            
        }

        if (val == 1)
        {
            
            letter_to_focus =1;
            
        }

        if (val == 2)
        {
            
            letter_to_focus = 2;
           
        }

        if (val == 3)
        {
            
            letter_to_focus = 3;
            
        }

        if (val == 4)
        {
            
            letter_to_focus = 4;
            
        }

        if (val == 5)
        {
            
            letter_to_focus = 5;
           
        }

        if (val == 6)
        {
            
            letter_to_focus = 6;
            
        }

        if (val == 7)
        {
            
            letter_to_focus = 7;
            
        }

        if (val == 8)
        {
            
            letter_to_focus = 8;
            
        }

        if (val == 9)
        {
            
            letter_to_focus = 9;
            
        }

        if (val == 10)
        {
            
            letter_to_focus = 10;
            
        }

        if (val == 11)
        {
            
            letter_to_focus = 11;
            
        }

        if (val == 12)
        {
            
            letter_to_focus = 12;
           
        }

        if (val == 13)
        {
            
            letter_to_focus = 13;
          
        }

        if (val == 14)
        {
            
            letter_to_focus = 14;
            
        }

        if (val == 15)
        {
           
            letter_to_focus = 15;
           
        }

        if (val == 16)
        {
           
            letter_to_focus = 16;
            
        }

        if (val == 17)
        {
            
            letter_to_focus = 17;
           
        }

        if (val == 18)
        {
            
            letter_to_focus = 18;
           
        }

        if (val == 19)
        {
           
            letter_to_focus = 19;
            
        }

        if (val == 20)
        {
           
            letter_to_focus = 20;
            
        }

        if (val == 21)
        {
           
            letter_to_focus = 21;
           
        }

        if (val == 22)
        {

            letter_to_focus = 22;
        }

        if (val == 23)
        {
            letter_to_focus = 23;
            
        }

        if (val == 24)
        {
            
            letter_to_focus = 24;
            
        }

        if (val == 25)
        {
           
            letter_to_focus = 25;
            
        }
        

    }

    public void nextScene()
    {
        SceneManager.LoadScene("BlankAR");
    }
}
