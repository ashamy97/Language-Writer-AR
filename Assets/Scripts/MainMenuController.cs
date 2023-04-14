using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject startButton;
    public GameObject settingsButton;
    public GameObject aboutButton;
    public GameObject quitButton;
    public GameObject backButton;
    public GameObject aboutText;
    public GameObject volumeSlider;
    public GameObject volumeImage;
    public GameObject title;
    public GameObject audioControl;

    public void startButtonPressed()
    {
        SceneManager.LoadScene("Letter Picker");
    }

    public void About()
    {
        startButton.SetActive(false);
        settingsButton.SetActive(false);
        aboutButton.SetActive(false);
        quitButton.SetActive(false);
        backButton.SetActive(true);
        aboutText.SetActive(true);
        title.SetActive(false);
    }

    public void Settings()
    {
        startButton.SetActive(false);
        settingsButton.SetActive(false);
        aboutButton.SetActive(false);
        quitButton.SetActive(false);
        backButton.SetActive(true);
        volumeImage.SetActive(true);
        volumeSlider.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void backButtonPressed()
    {
        startButton.SetActive(true);
        settingsButton.SetActive(true);
        aboutButton.SetActive(true);
        quitButton.SetActive(true);
        backButton.SetActive(false);
        aboutText.SetActive(false);
        volumeImage.SetActive(false);
        volumeSlider.SetActive(false);
        title.SetActive(true);
    }

    public void changeVolume()
    {
        float value = volumeSlider.GetComponent<Slider>().value;
        audioControl = GameObject.FindWithTag("GameMusic");
        audioControl.GetComponent<AudioSource>().volume = value;
    }

    
}
