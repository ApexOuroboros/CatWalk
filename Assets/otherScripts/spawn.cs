using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject bee;
    public GameObject cat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(bee, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(cat, transform.position, Quaternion.identity);
        }
    }
}
