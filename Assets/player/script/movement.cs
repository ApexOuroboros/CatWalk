using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]

public class movement : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jSpeed = 8.0f;
    public float g = 20.0f;

    private Vector3 mDir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            mDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            mDir *= speed;

            if (Input.GetButton("Jump"))
            {
                mDir.y = jSpeed;
            }
        }

        mDir.y -= g * Time.deltaTime;

        characterController.Move(mDir * Time.deltaTime);
    }
}
