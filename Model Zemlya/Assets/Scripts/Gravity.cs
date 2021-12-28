using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private float alpha = 90, r, p, e, a, m =  2, v = 1, k0, e0, betta = 0, G = 6.67e-11f, mc = 6e11f;
        
    void Start()
    {
        r = Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.y, 2) + Mathf.Pow(transform.position.z, 2));
        float temp = Mathf.Acos(Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.z, 2)) / r);
        alpha += 90 - Mathf.Rad2Deg * temp;
        k0 = r * m * v;
        a = m * mc * G;
        e0 = m * v * v / 2 - a / r;
        p = k0 * k0 / (m * a);
        e = Mathf.Sqrt(1 + 2 * e0 * k0 * k0 / (m * a * a));
    }

   
    void Update()
    {
        betta += k0 / (m * r * r);
        r = p / (1f + e * Mathf.Cos(betta * Mathf.Deg2Rad));
        transform.position = new Vector3(- r * Mathf.Cos(betta * Mathf.Deg2Rad), r * Mathf.Sin(betta * Mathf.Deg2Rad), 0);
    }
}
