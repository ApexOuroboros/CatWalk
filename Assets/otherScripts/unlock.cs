using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Konami))]
public class unlock : MonoBehaviour
{

    public Text successText;

    private Konami konami;

    // Start is called before the first frame update
    void Start()
    {
        konami = GetComponent<Konami>();
    }

    // Update is called once per frame
    void Update()
    {
        if (konami.success)
        {
            successText.gameObject.SetActive(true);
        }
    }
}
