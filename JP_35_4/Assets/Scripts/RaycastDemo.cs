using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    private LayerMask LayerMask;

    private void Start()
    {
        LayerMask = (1 << 3) | (1 << 4);
        
    }
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 200, LayerMask))
        {
            Debug.Log(hit.transform.name);
        }
        else
        {
            Debug.Log("arafers ar uyurebs");
        }
    }
}
