using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osc : MonoBehaviour
{
    private float amplitude; 
    private float k = 0.5f;

    public float Velocity = 2f;
    public float m = 1f;
    public float StartLoc = 2.0f;

    void Start()
    {
        amplitude = Mathf.Sqrt(Mathf.Pow(StartLoc,2) + Mathf.Pow(Velocity,2) / Mathf.Pow(k,2));
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time * Mathf.Sqrt(m / k) + Mathf.Atan(StartLoc * k / Velocity)) * amplitude, 2, 0);
    }
}
