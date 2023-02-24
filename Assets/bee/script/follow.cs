using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public float speed;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(180, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
