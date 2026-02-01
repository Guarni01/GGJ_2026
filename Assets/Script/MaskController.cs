using UnityEngine;
using System.Collections;
public class MaskController : MonoSingleton<MaskController>
{
    public bool Mask_1;
    public bool Mask_2;
    public bool Mask_3;
    public bool UnlockMask_1=false;
    public bool UnlockMask_2=false;
    public bool UnlockMask_3=false;
    public bool Skill1;
    public bool Skill2;
    public bool Skill3;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && UnlockMask_1) //PickMask1
        {
            Mask_1 = true;
            Mask_2 = false;
            Mask_3 = false;
        }
        if (Input.GetKeyDown(KeyCode.S) && UnlockMask_2) //PickMask2
        {
            Mask_1 = false;
            Mask_2 = true;
            Mask_3 = false;
        }
        if (Input.GetKeyDown(KeyCode.D) && UnlockMask_3) //PickMask3
        {
            Mask_1 = false;
            Mask_2 = false;
            Mask_3 = true;
        }
        if (Mask_1)
        {
            PlayerUI.Instance.Mask1_selected();
            AudioController.Instance.PlayClip(0);
            Skill1 = true;
            Skill2 = false;
            Skill3 = false;
        }
        //if (!Mask_1)
        //{
        //    PlayerUI.Instance.Mask1_unselected();
        //    Skill1 = false;
        //}
        if (Mask_2)
        {
            PlayerUI.Instance.Mask2_selected();
            AudioController.Instance.PlayClip(1);
            Skill1 = false;
            Skill2 = true;
            Skill3 = false;
        }
        //if (!Mask_2)
        //{
        //    PlayerUI.Instance.Mask2_unselected();
        //    Skill2 = false;
        //}
        if (Mask_3)
        {
            AudioController.Instance.PlayClip(2);
            PlayerUI.Instance.Mask3_selected();
            Skill1 = false;
            Skill2 = false;
            Skill3 = true;
        }
        //if (!Mask_3)
        //{
        //    PlayerUI.Instance.Mask3_unselected();
        //    Skill3 = false;
        //}
        if (Skill1)
        {
            LevelController.Instance.Lv1.SetActive(true);
            LevelController.Instance.Lv2.SetActive(false);
            LevelController.Instance.Lv3.SetActive(false);
        }
        if (Skill2)
        {
            LevelController.Instance.Lv1.SetActive(false);
            LevelController.Instance.Lv2.SetActive(true);
            LevelController.Instance.Lv3.SetActive(false);
        }
        if (Skill3)
        {
            LevelController.Instance.Lv1.SetActive(false);
            LevelController.Instance.Lv2.SetActive(false);
            LevelController.Instance.Lv3.SetActive(true);
        }
    }
}
