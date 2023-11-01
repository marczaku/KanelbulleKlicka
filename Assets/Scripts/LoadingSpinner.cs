using System.Collections;
using System.Threading;
using UnityEngine;

public class LoadingSpinner : MonoBehaviour
{
    public Animator animator;
    public void LoadStuff()
    {
        StartCoroutine(Co_LoadStuff());
    }

    IEnumerator Co_LoadStuff()
    {
        this.animator.SetBool("IsShown", true);
        yield return new WaitForSeconds(5);
        this.animator.SetBool("IsShown", false);
    }
}
