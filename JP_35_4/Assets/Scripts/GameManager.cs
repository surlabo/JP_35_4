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
        Debug.Log("GameManger");
        var spawnedPlayer = Instantiate(player, spawnPosition.position, Quaternion.identity);
        spawnedPlayer.transform.parent = parent;
    }
}
