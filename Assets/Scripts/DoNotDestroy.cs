using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    /*private void Update()
    {
        if (SceneManager.GetActiveScene().name == "BlankAR")
        {
            this.gameObject.GetComponent<AudioSource>().Pause();
        }
        this.gameObject.GetComponent<AudioSource>().Play();

    }*/

    public void PlayMusic()
    {
        if (this.gameObject.GetComponent<AudioSource>().isPlaying)
        {
            return;
        }
        this.gameObject.GetComponent<AudioSource>().Play();
    }

    public void StopMusic()
    {
        this.gameObject.GetComponent<AudioSource>().Stop();
    }
}
