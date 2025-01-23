using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float delayTime;

    private void Start()
    {
        StartCoroutine(DelayDestory(delayTime));
    }

    IEnumerator DelayDestory(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
