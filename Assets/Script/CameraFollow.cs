using UnityEngine;

public class CameraFollow : MonoSingleton<CameraFollow>
{
    public Transform target; 
    public float smoothing = 0.125f; 
    public Vector3 offset; 

    void LateUpdate()
    {if(!MaskController.Instance.UnlockMask_2)
        {
            Vector3 desiredPosition = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothing);
            transform.position = smoothedPosition;
        }
        else
        {
            Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y+offset.x, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothing);
            transform.position = smoothedPosition;
        }
    }
}
