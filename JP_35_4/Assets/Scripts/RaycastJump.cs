using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RaycastJump : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 2))
        {
            if (hit.transform.CompareTag("Floor") && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * 500);
            }
        }
        Debug.DrawRay(transform.position, Vector3.down * 2, Color.green);
        
    }
}
