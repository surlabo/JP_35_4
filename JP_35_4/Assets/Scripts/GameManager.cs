using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPosition;
    public Transform parent;
    public Transform startSpawnPoint;
    public List<Transform> spawnPoints;
    private GameObject playerClone;


    void Start()
    {
        //StartGame();

        int x = 0;
        var car = new Car();
        car.y = 0;
        
        ChangeCar(car);
        Debug.Log(x);
        Debug.Log(car.y);
    }


    private bool Count(out int x)
    {
        x = 10;
        x+=1;
        return x == 1;
    }

    public void ChangeCar(Car car)
    {
        car.y += 1;
    }

    public void StartGame()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        if (PlayerPrefs.HasKey("LevelId"))
        {
            var platformId = PlayerPrefs.GetInt("LevelId");

            playerClone = CreatePlayer(spawnPoints[platformId].position);
        }
        else
        {
            playerClone = CreatePlayer(startSpawnPoint.position);

        }

        playerClone.GetComponent<Death>().gameManager = this;

    }

    private GameObject CreatePlayer(Vector3 spawnPosition)
    {
        return Instantiate(player, spawnPosition, Quaternion.identity);
    }
    
    public void RespawnPlayer()
    {
        if (PlayerPrefs.HasKey("LevelId"))
        {
            var platformId = PlayerPrefs.GetInt("LevelId");

            playerClone.transform.position = spawnPoints[platformId].position;
        }
        else
        {
            playerClone.transform.position = startSpawnPoint.position;
        }
    }
}


public class Car
{
    public int y;
}

public struct Home
{

}