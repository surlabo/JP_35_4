using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterParentController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Platform"))
        {
            this.transform.SetParent(collision.transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Platform"))
        {
            this.transform.SetParent(null);
        }
    }
}
