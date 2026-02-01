using UnityEngine;
using System.Collections;

public class AnimatorController : MonoSingleton<AnimatorController>
{
    public Animator animator;
    public int directions;
    public bool latodx;

    void Update()
    {


        if(directions==-1)
        {
            animator.SetInteger("Direction", -1);
            StartCoroutine(stop());
        }

        if(directions==1)
        {
            animator.SetInteger("Direction", 1);
      
        }
        if (directions == 0)
        {
            animator.SetInteger("Direction", 0);

        }

        if (directions == -2)
        {
            animator.SetInteger("Direction", -2);
            if(latodx)
            {
                animator.SetBool("LatoDX", true);
            }
            else
            {
                animator.SetBool("LatoDX", false);
            }
        }

        if (directions == 2)
        {
            animator.SetInteger("Direction", 2);
            if (latodx)
            {
                animator.SetBool("LatoDX", true);
            }
            else
            {
                animator.SetBool("LatoDX", false);
            }
        }

        if (directions == 3)
        {
            animator.SetInteger("Direction", 3);
        }

    }
    IEnumerator stop()
    {
        yield return new WaitForSeconds(1f);
        
        directions = 0;
    }

}
