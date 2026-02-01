using UnityEngine;

public class PlayerUI : MonoSingleton<PlayerUI>
{
    public GameObject Mask1_on;
    public GameObject Mask1_off;
    public GameObject Mask2_on;
    public GameObject Mask2_off;
    public GameObject Mask3_on;
    public GameObject Mask3_off;
    public GameObject Dialogo1;

    public  void Mask1_selected()
    {
        Mask1_on.SetActive(true);
        Mask1_off.SetActive(false);
        Mask2_on.SetActive(false);
        Mask2_off.SetActive(false);
        Mask3_on.SetActive(false);
        Mask3_off.SetActive(false);
    }

    public void Mask1_unselected()
    {
        Mask1_on.SetActive(false);
        Mask1_off.SetActive(true);
        Mask2_on.SetActive(false);
        Mask2_off.SetActive(false);
        Mask3_on.SetActive(false);
        Mask3_off.SetActive(false);
    }

    public void Mask2_selected()
    {
        Mask1_on.SetActive(false);
        Mask1_off.SetActive(false);
        Mask2_on.SetActive(true);
        Mask2_off.SetActive(false);
        Mask3_on.SetActive(false);
        Mask3_off.SetActive(false);
    }

    public void Mask2_unselected()
    {
        Mask1_on.SetActive(false);
        Mask1_off.SetActive(false);
        Mask2_on.SetActive(false);
        Mask2_off.SetActive(true);
        Mask3_on.SetActive(false);
        Mask3_off.SetActive(false);
    }
    public void Mask3_selected()
    {
        Mask1_on.SetActive(false);
        Mask1_off.SetActive(false);
        Mask2_on.SetActive(false);
        Mask2_off.SetActive(false);
        Mask3_on.SetActive(true);
        Mask3_off.SetActive(false);
    }

    public void Mask3_unselected()
    {
        Mask1_on.SetActive(false);
        Mask1_off.SetActive(false);
        Mask2_on.SetActive(false);
        Mask2_off.SetActive(true);
        Mask3_on.SetActive(false);
        Mask3_off.SetActive(true);
    }

    void Update()
    {
        if(MaskController.Instance.UnlockMask_2)
        {
            Dialogo1.SetActive(true);

        }
    }

}
