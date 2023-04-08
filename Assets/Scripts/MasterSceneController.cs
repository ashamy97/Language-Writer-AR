using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterSceneController : MonoBehaviour
{
    LineAnimator lineAnimator;
    public void reanimate()
    {
        GameObject letterA = GameObject.FindGameObjectWithTag("Letter A");
        letterA.GetComponent<LineAnimator>().reanimate();
    }

    public void goBack()
    {
        SceneManager.LoadScene("Letter Picker");
    }

    
}
