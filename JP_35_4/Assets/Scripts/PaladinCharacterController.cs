using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinCharacterController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private int animTransSmoothness;

    private void Update()
    {
        PlayerMovement();
        PlayerRotation();
        Punch();

    }

    private void Punch()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            animator.SetTrigger("Punch");
        }
    }


    private void PlayerMovement()
    {
        var moveDir = Input.GetAxis("Vertical");
        transform.Translate(0, 0, moveDir * moveSpeed * Time.deltaTime);
        var tempSmoothness = Mathf.Lerp(animator.GetFloat("Blend"), moveDir, Time.deltaTime * animTransSmoothness);
        animator.SetFloat("Blend", tempSmoothness);
    }


    private void PlayerRotation()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
    }
}
