using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text point;

    private int count = 0;

    private void Start()
    {
        StartCoroutine(Counter());
    }

    IEnumerator Counter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            count++;
            point.text = count.ToString();
        }
    }
}
