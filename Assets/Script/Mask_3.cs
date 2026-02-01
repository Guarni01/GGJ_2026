using UnityEngine;

public class Mask_3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MaskController.Instance.UnlockMask_3 = true;
            gameObject.SetActive(false);
        }

    }
}
