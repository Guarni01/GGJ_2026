using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class DialogueController : MonoBehaviour
{
    public GameObject testo1;
    public GameObject testo2;
    public GameObject Avanti;
    public GameObject Gioco;
    void Start()
    {
        Avanti.SetActive(true);
        Gioco.SetActive(false);
        testo1.SetActive(true);
        testo2.SetActive(false);
    }
    public void CambiaTesto()
    {
        
        Avanti.SetActive(false);
        Gioco.SetActive(true);
        testo1.SetActive(false);
        testo2.SetActive(true);
    }
    public void CominciaGioco()
    {
        SceneManager.LoadScene("Hub");
    }

}
