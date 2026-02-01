using UnityEngine;

public class Mask_1 : MonoBehaviour
{
    public GameObject startlevel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        startlevel.SetActive(false);

            MaskController.Instance.Mask_1 = true;
            MaskController.Instance.UnlockMask_1=true;
            
        
        gameObject.SetActive(false);
    }
}
