using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnHere;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER");
        if (other.CompareTag("Player"))
        {
            Debug.Log("IS PLAYER " + other.transform.position.ToString());
            other.transform.position = spawnHere.transform.position;
            Debug.Log("MOVED? " + other.transform.position.ToString());
        }
        
    }
}
