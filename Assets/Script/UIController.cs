using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject Start;
    public GameObject Option;
    public GameObject OptionScreen;
    public GameObject AudioOn;
    public GameObject AudioOff;
    public GameObject Quit;
    public GameObject Pause;
    public GameObject Unpause;
    public GameObject Quit2;


    public void ShowStartGame()
    {
        Start.SetActive(true);
    }
    public void HideStartGame()
    {
        Start.SetActive(false);
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
    }
    public void HideOptionScreen()
    {
        OptionScreen.SetActive(false);
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
}
