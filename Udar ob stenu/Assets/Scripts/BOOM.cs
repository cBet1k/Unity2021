using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM : MonoBehaviour
{
    private Rigidbody projectile;
    private Vector3 dir;
    public float xd = -80, yd = 120, zd = 30;
    public float force = 10;
    private void Awake()
    {
        projectile = GetComponent<Rigidbody>();
        dir = new Vector3(xd, yd, zd).normalized;
    }
    public void Fire()
    {
        projectile.AddForce(dir * force, ForceMode.Impulse);
    }
}
