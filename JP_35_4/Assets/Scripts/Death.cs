using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public Transform SpawnPosition;
    void Update()
    {
        if (transform.position.y < -10)
        {
            transform.position = SpawnPosition.position;
        }
    }

    

}
