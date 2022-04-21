using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float force = 50;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -1) * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
