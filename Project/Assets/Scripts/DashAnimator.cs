using System.Collections;
using UnityEngine;

public class DashAnimator : MonoBehaviour
{
private Animator anim;

private void Start()
{
    anim = GetComponent<Animator>();
}

private void Update()
{
    if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
    {
        anim.SetTrigger("Dashing");
    }
    else if (Input.GetKeyDown(KeyCode.Space))
    {
        anim.SetTrigger("Jump");
    }
}

}
