using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        var opposite = -collision.gameObject.GetComponent<Rigidbody>().velocity;

        collision.gameObject.GetComponent<Rigidbody>().AddForce(opposite * 10);

    }
}
