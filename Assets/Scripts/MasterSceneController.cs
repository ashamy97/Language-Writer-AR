using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.XR.ARFoundation;

public class MasterSceneController : MonoBehaviour
{
    public int letter_to_focus = 0;
    public GameObject letterPicker;
    public GameObject interactCanvas;
    public GameObject languageCanvas;
    public GameObject englishLetters;
    string language;
    public GameObject start;
    
    
  
    
    public void goBack()
    {
        SceneManager.LoadScene("Letter Picker");
        GameObject.FindGameObjectWithTag("GameMusic").GetComponent<DoNotDestroy>().PlayMusic();
    }

    

    

    public void ShowLetter()
    {
        SceneManager.LoadScene("BlankAR");
        
    }

    

    
}
