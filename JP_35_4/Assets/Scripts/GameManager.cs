using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPosition;
    public Transform parent;
    public Transform spawnPoint;
    public List<Transform> spawnPoints;
        GameObject playerClone;


    void Start()
    {
        
    }

    public void StartGame()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        Debug.Log(PlayerPrefs.HasKey("LevelId"));
        if (PlayerPrefs.HasKey("LevelId"))
        {
            var platformId = PlayerPrefs.GetInt("LevelId");
            Debug.Log(platformId);
            var newSpawnPoint = spawnPoints[platformId];
            playerClone = Instantiate(player, newSpawnPoint.position, Quaternion.identity);
        }
        else
        {
            playerClone = Instantiate(player, spawnPosition.position, Quaternion.identity);
            
        }
        playerClone.GetComponent<Death>().SpawnPosition = spawnPoint;




    }

    


}
