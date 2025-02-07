using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastJump : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        var hit = new RaycastHit();
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 2))
        {
            if (hit.transform.CompareTag("Floor") && Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
            }
        }
        Debug.DrawRay(transform.position, Vector3.down * 2, Color.green);
        
    }
}
