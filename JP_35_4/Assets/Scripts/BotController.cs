using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;
    [SerializeField] private NavMeshAgent agent;
        

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
        // transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}
