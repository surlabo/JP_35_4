using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameManager gameManager;
    void Update()
    {
        if (transform.position.y < -10)
        {
            gameManager.RespawnPlayer();
        }
    }

    

}
