using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorHandler : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetBool("IsRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetBool("IsRunning", false);
        }
    }
}
