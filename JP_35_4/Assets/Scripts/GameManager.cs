using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPosition;
    public Transform parent;
    public Transform spawnPoint;
    
    void Start()
    {
        
    }

    public void StartGame()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        var playerClone = Instantiate(player, spawnPosition.position, Quaternion.identity);
        playerClone.GetComponent<Death>().SpawnPosition = spawnPoint;
    }
}
