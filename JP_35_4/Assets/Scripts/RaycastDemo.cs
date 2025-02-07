using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {

            Debug.Log(hit.transform.name);
        }
        else
        {
            Debug.Log("arafers ar uyurebs");
        }
    }
}
