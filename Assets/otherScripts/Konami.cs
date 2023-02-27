using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Konami : MonoBehaviour
{
    private KeyCode[] keys = new KeyCode[]
    {
        KeyCode.UpArrow,
        KeyCode.UpArrow,
        KeyCode.DownArrow,
        KeyCode.DownArrow,
        KeyCode.LeftArrow,
        KeyCode.RightArrow,
        KeyCode.LeftArrow,
        KeyCode.RightArrow,
        KeyCode.B,
        KeyCode.A,
        KeyCode.KeypadEnter
    };

    public bool success;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        float timer = 0f;
        int index = 0;

        while (true)
        {
            if (Input.GetKeyDown(keys[index]))
            {
                index++;

                if (index == keys.Length)
                {
                    success = true;
                    timer = 0f;
                }
                else
                {
                    timer = 0.25f;
                }
            }
            timer -= Time.deltaTime;
            if (timer < 0f)
               {
                timer = 0f;
                index = 0;
            }

        }

    }

}
