using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShoot : MonoBehaviour
{
    [SerializeField] float shootingDistance = 100;
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject vfxPlaceholder;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && 
            Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, shootingDistance))
        {
            hitInfo.transform.GetComponent<Renderer>().material.color = Color.red;
            Instantiate(vfxPlaceholder, hitInfo.point, Quaternion.identity);
             //Debug.Log(hitInfo.transform.name);
   
        }
    }
}
