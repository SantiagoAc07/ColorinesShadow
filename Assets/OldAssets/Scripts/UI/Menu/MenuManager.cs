using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject OptionsWindow;
    [SerializeField] GameObject creditsWindow;

    private void Awake()
    {
        OptionsWindow.SetActive(false);
        creditsWindow.SetActive(false);
    }

    public void PlayOnePlayer()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayTwoPlayer()
    {
        SceneManager.LoadScene(2);
    }

    public void Options()
    {
        OptionsWindow.SetActive(true);
    }

    public void Volver()
    {
        OptionsWindow.SetActive(false);
        creditsWindow.SetActive(false);
    }
    

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliste de el juego");
    }
    
    public void Credits()
    {
        creditsWindow.SetActive(true);
    }

    public void GoBackCredits()
    {
        creditsWindow.SetActive(false);
    }
    

}
