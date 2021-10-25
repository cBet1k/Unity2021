using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    private float W = 0.0f;
    private float L = 10.0f;
    private float Betta = 0.0f;

    public float Vel = 2.0f;
    public float Alpha = 0.5f;

    

    void Start()
    {
        W = Mathf.Sqrt(9.8f / L);
    }

    void Update()
    {
        Betta = Mathf.Sin(Time.time * W + Mathf.Atan(Alpha * W / Vel)) * Mathf.Sqrt(Mathf.Pow(Alpha, 2) * (Mathf.Pow(Vel, 2) / Mathf.Pow(W, 2)));
        transform.position = new Vector3(L*Mathf.Sin(Betta),L - L* Mathf.Cos(Betta) , 0);
    }
}
