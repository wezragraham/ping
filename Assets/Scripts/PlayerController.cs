using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float movementMultiplier;

    [SerializeField]
    int playerNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(playerNum);
    }

    void MovePaddle(int player)
    {
        if (player == 1)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * movementMultiplier * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(-Vector3.up * movementMultiplier * Time.deltaTime);
            }

        }
        else if (player == 2)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * movementMultiplier * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-Vector3.up * movementMultiplier * Time.deltaTime);
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

            collision.rigidbody.AddForce(-collision.relativeVelocity, ForceMode.Impulse);

    }
}
