using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float sprintSpeed;
    public float rotateSpeed;
    public float jumpForce;
    public Color defaulColor;
    public Color newColor;
    public int timerValue;

    private Rigidbody rb;
    private bool isGrounded;
    private Coroutine timerCoroutine;

    private void Start()
    {
        Debug.Log("Player");
        rb = GetComponent<Rigidbody>();
        PlayerRotation();
    }

    

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            PlayerMovement(sprintSpeed);
        }
        else
        {
            PlayerMovement(speed);
        }
       

        PlayerRotation();

        PlayerJump();


    }

    private void PlayerMovement(float newSpeed)
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * newSpeed * Time.deltaTime);
    }

    private void PlayerRotation()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);
    }    

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine);
        }


        if (collision.gameObject.name == "Floor")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = newColor;
            isGrounded = true;
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        

        if (collision.gameObject.tag == "Floor")
        {
            timerCoroutine = StartCoroutine(DetectTimer());
            collision.gameObject.GetComponent<MeshRenderer>().material.color = defaulColor;
            isGrounded = false;
        }
    }

    IEnumerator DetectTimer()
    {
        yield return new WaitForSeconds(2);

        Destroy(this.gameObject);

    }
}

