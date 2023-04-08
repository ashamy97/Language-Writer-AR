using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickLetter : MonoBehaviour
{
    public GameObject englishLetter;
    private GameObject letterToDisplay;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        letterToDisplay = englishLetter.transform.GetChild(LetterPickerScene.letter_to_focus).gameObject;
        letterToDisplay.SetActive(true);
    }

    public void animate()
    {
        //0 is A (LA), 1 is B (LA2), 2 is C (LA2), 3 is D (LA2), 4 is E (LEA), 5 is F (LA), 6 is G (LA2),
        //7 is H (LEA), 8 is I (LEA), 9 is J (LJA), 10 is K (LEA), 11 is L (LA), 12 is M (LJA)
        //13 is N (LEA), 14 is O (LJA), 15 is P (LJA), 16 is Q (LQA), 17 is R (LQA),
        //18 is S (LA2), 19 is T (LA), 20 is U (LEA), 21 is V (LA), 22 is W (LJA), 23 is X (LA), 24 is Y (LEA)
        //25 is Z (LEA)

        int letter_to_animate = LetterPickerScene.letter_to_focus;

        if (letter_to_animate == 0 || letter_to_animate == 5 || letter_to_animate == 11 || letter_to_animate == 19
            || letter_to_animate == 21 || letter_to_animate == 23)
        {
            letterToDisplay.GetComponent<LineAnimator>().reanimate();
        }

        if (letter_to_animate == 1 || letter_to_animate == 2 || letter_to_animate == 3 || letter_to_animate == 6
            || letter_to_animate == 18)
        {
            letterToDisplay.GetComponent<LineAnimator2>().reanimate();
        }

        if (letter_to_animate == 4 || letter_to_animate == 7 || letter_to_animate == 8 || letter_to_animate == 10
            || letter_to_animate == 13 || letter_to_animate == 20 || letter_to_animate == 24 || letter_to_animate == 25)
        {
            letterToDisplay.GetComponent<LetterEAnimator>().reanimate();
        }

        if (letter_to_animate == 9 || letter_to_animate == 12 || letter_to_animate == 14 || letter_to_animate == 15
            || letter_to_animate == 22)
        {
            letterToDisplay.GetComponent<LetterJAnimator>().reanimate();
        }

        if (letter_to_animate == 16 || letter_to_animate == 17)
        {
            letterToDisplay.GetComponent<LetterQAnimator>().reanimate();
        }
    }

    public void playSound()
    {
        audioSource = letterToDisplay.GetComponent<AudioSource>();
        audioSource.Play();
    }


}
