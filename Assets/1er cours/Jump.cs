using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Rigidbody rgbd;
    public float force = 1000;

    private void Start()
    {
        DoJump();
    }

    public void DoJump()
    {
        rgbd.AddForce(new Vector3(0, force, 0));
    }
}
