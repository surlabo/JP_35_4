using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPosition;
    public Transform parent;
    
    void Start()
    {
        var spawnedPlayer = Instantiate(player, spawnPosition.position, Quaternion.identity);
    }
}
