using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickLetter : MonoBehaviour
{
    public GameObject englishLetter;
    // Start is called before the first frame update
    void Start()
    {
        GameObject letterToDisplay = englishLetter.transform.GetChild(LetterPickerScene.letter_to_focus).gameObject;
        letterToDisplay.SetActive(true);
    }

    public void animate()
    {
        
    }

    
}
