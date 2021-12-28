using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public Vector3 V;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Moment = new Vector3(10, 60, 45).normalized;
        float Const = 30f;
        Vector3 force = Moment * Const * Time.fixedDeltaTime;
        GetComponent<Rigidbody>().AddTorque(force, ForceMode.Impulse);
    }
}
