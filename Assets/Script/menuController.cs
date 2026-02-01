using UnityEngine;

public class menuController : MonoBehaviour
{
    public GameObject StartGame;
    public GameObject Option;
    public GameObject OptionScreen;
    public GameObject AudioOn;
    public GameObject AudioOff;
    public GameObject Quit;
    public GameObject Pause;
    public GameObject Unpause;
    public GameObject Quit2;
    public GameObject Credits;
    public GameObject MenuBtn;

 
    public void ShowStartGame()
    {
        StartGame.SetActive(true);
    }
    public void HideStartGame()
    {
        StartGame.SetActive(false);
    }
    public void ShowOptionsGame()
    {
        Option.SetActive(true);
    }
    public void HideOptionsGame()
    {
        Option.SetActive(false);
    }
    public void ShowOptionScreen()
    {
        OptionScreen.SetActive(true);
        MenuBtn.SetActive(false);
    }
    public void HideOptionScreen()
    {
        OptionScreen.SetActive(false);
        MenuBtn.SetActive(true);
    }
    public void ShowQuitGame()
    {
        Quit.SetActive(true);
    }
    public void HideQuitGame()
    {
        Quit.SetActive(false);
    }
    public void ShowPauseGame()
    {
        Pause.SetActive(true);
    }
    public void HidePauseGame()
    {
        Pause.SetActive(false);
    }
    public void ShowUnpausedGame()
    {
        Unpause.SetActive(true);
    }
    public void HideUnpausedGame()
    {
        Unpause.SetActive(false);
    }
    public void ShowBackMenuGame()
    {
        Quit2.SetActive(true);
    }
    public void HideBackMenuGame()
    {
        Quit2.SetActive(false);
    }
    public void ShowCredits()
    {
        Credits.SetActive(true);
        MenuBtn.SetActive(false);
    }
    public void HideCredits()
    {
        Credits.SetActive(false);
        MenuBtn.SetActive(true);
    }
    public void SetAudioOn()
    {
        GetComponent<AudioSource>().Play();
        AudioOn.SetActive(true);
        AudioOff.SetActive(false);
    }
    public void SetAudioOff()
    {
        GetComponent<AudioSource>().Stop();
        AudioOn.SetActive(false);
        AudioOff.SetActive(true);
    }
}
