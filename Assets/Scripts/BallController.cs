using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody>();
        myRigidbody.AddForce(new Vector3(1, 0.4f) * 10, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
