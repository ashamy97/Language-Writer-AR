using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LetterPickerScene : MonoBehaviour
{
    public static int letter_to_focus = 0;
    public GameObject letterPicker;
    string language;
    public GameObject start;

    public void pickLanguage(int val)
    {
        var dropdown = letterPicker.GetComponent<TMP_Dropdown>();
        if (val == 0)
        {
            
            dropdown.options.Clear();
            dropdown.RefreshShownValue();
            language = "none";
            start.SetActive(false);
        }

        if (val == 1)
        {
            List<string> englishLetters = new List<string> { "Letter A", "Letter B", "Letter C", 
                                                    "Letter D", "Letter E", "Letter F",
                                                    "Letter G", "Letter H", "Letter I",
                                                    "Letter J", "Letter K", "Letter L",
                                                    "Letter M", "Letter N", "Letter O",
                                                    "Letter P", "Letter Q", "Letter R",
                                                    "Letter S", "Letter T", "Letter U",
                                                    "Letter V", "Letter W", "Letter X",
                                                    "Letter Y", "Letter Z"};
            dropdown.options.Clear();
            foreach (string option in englishLetters)
            {
                dropdown.options.Add(new TMP_Dropdown.OptionData(option));
            }
            dropdown.value = 0; //this is the start of english letters
            letter_to_focus = 0;
            dropdown.RefreshShownValue();
            language = "english";
            start.SetActive(true);
        }

        if (val == 2)
        {
            List<string> arabicLetters = new List<string> { "Letter ALEF", "Letter BA", "Letter TA",
                                                    "Letter Tha", "Letter Jeem", "Letter Ha",
                                                    "Letter Kha", "Letter Dal", "Letter Dhal",
                                                    "Letter Ra", "Letter Jaa", "Letter Seen",
                                                    "Letter Sheen", "Letter Saad", "Letter Dhaad",
                                                    "Letter Toa", "Letter Dhaa", "Letter Ain",
                                                    "Letter Ghain", "Letter Fa", "Letter Qaaf",
                                                    "Letter Kaaf", "Letter Laam", "Letter Meem",
                                                    "Letter Noon", "Letter Ha", "Letter Waw",
                                                    "Letter Yaa"};
            dropdown.options.Clear();
            foreach (string option in arabicLetters)
            {
                dropdown.options.Add(new TMP_Dropdown.OptionData(option));
            }
            dropdown.value = 0; //this is the start of arabic letters
            letter_to_focus = 26;
            dropdown.RefreshShownValue();
            language = "arabic";
            start.SetActive(true);
        }
    }
    
   public void pickLetter (int val)
    {
        
        if (language == "english")
        {
            if (val == 0)
            {

                letter_to_focus = 0;


            }

            if (val == 1)
            {

                letter_to_focus = 1;

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

        
        if (language == "arabic")
        {
            
            if (val == 0)
            {

                letter_to_focus = 26;

            }

            if (val == 1)
            {

                letter_to_focus = 27;

            }

            if (val == 2)
            {

                letter_to_focus = 28;

            }

            if (val == 3)
            {

                letter_to_focus = 29;

            }

            if (val == 4)
            {

                letter_to_focus = 30;

            }

            if (val == 5)
            {

                letter_to_focus = 31;

            }

            if (val == 6)
            {

                letter_to_focus = 32;

            }

            if (val == 7)
            {

                letter_to_focus = 33;

            }

            if (val == 8)
            {

                letter_to_focus = 34;

            }

            if (val == 9)
            {

                letter_to_focus = 35;

            }

            if (val == 10)
            {

                letter_to_focus = 36;

            }

            if (val == 11)
            {

                letter_to_focus = 37;

            }

            if (val == 12)
            {

                letter_to_focus = 38;

            }

            if (val == 13)
            {

                letter_to_focus = 39;

            }

            if (val == 14)
            {

                letter_to_focus = 40;

            }

            if (val == 15)
            {

                letter_to_focus = 41;

            }

            if (val == 16)
            {

                letter_to_focus = 42;

            }

            if (val == 17)
            {

                letter_to_focus = 43;

            }

            if (val == 18)
            {

                letter_to_focus = 44;

            }

            if (val == 19)
            {

                letter_to_focus = 45;

            }

            if (val == 20)
            {

                letter_to_focus = 46;

            }

            if (val == 21)
            {

                letter_to_focus = 47;

            }

            if (val == 22)
            {

                letter_to_focus = 48;

            }

            if (val == 23)
            {

                letter_to_focus = 49;

            }

            if (val == 24)
            {

                letter_to_focus = 50;

            }

            if (val == 25)
            {

                letter_to_focus = 51;

            }

            if (val == 26)
            {

                letter_to_focus = 52;

            }

            if (val == 27)
            {

                letter_to_focus = 53;

            }
        }
        


    }

    public void nextScene()
    {
        SceneManager.LoadScene("BlankAR");
        GameObject.FindGameObjectWithTag("GameMusic").GetComponent<DoNotDestroy>().StopMusic();
    }

    public void goBack()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
