using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject button1;
    public GameObject button2;

    void Start()
    {
        button1.GetComponent<Button>().onClick.AddListener(() => { 
            button2.SetActive(true);
        });
    }
}

  