using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPosition;
    public float force;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var bulletClone = Instantiate(bullet, spawnPosition.position, spawnPosition.rotation);
            bulletClone.GetComponent<Rigidbody>().AddForce(spawnPosition.forward * force);
        }
    }
}
