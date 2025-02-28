using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinCharacterController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private int animTransSmoothness;
    [SerializeField] private float jumpDownDetectDistance;
    [SerializeField] private float jumpForce;



    private float previousPosition;
    private bool isJumping;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down * jumpDownDetectDistance, Color.red);
        
        PlayerMovement();
        PlayerRotation();
        
        Punch();
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping) 
        {
            isJumping = true;
            rb.AddForce(Vector3.up * jumpForce);
            animator.SetTrigger("JumpUp");
            StartCoroutine(JumpingUp());
        } 
    }
    private IEnumerator JumpingUp()
    {
        while (isJumping)
        {
            if (transform.position.y < previousPosition)
            {
                
                if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, jumpDownDetectDistance))
                {
                    animator.SetTrigger("JumpDown");
                    isJumping =false;
                }
            }
            previousPosition = transform.position.y;
            yield return null;
        }
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

        animator.SetFloat("Blend", moveDir);

        transform.Translate(0, 0, moveDir * moveSpeed * Time.deltaTime);

        //var tempSmoothness = Mathf.Lerp(animator.GetFloat("Blend"), moveDir, Time.deltaTime * animTransSmoothness);

    }


    private void PlayerRotation()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
    }
}
