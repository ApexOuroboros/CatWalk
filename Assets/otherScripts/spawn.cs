using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] mobs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            int rand = Random.Range(0, mobs.Length);

            Instantiate(mobs[rand], transform.position, Quaternion.identity);
        }
    }
}
