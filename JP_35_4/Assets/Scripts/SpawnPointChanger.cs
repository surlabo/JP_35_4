using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnPoint"))
        {
            PlayerPrefs.SetInt("LevelId", other.GetComponent<SpawnPointInfo>().platfromId);
        }
    }

}
