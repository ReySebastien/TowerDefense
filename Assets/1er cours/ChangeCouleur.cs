using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCouleur : MonoBehaviour
{

    public MeshRenderer msr;
    public float Couleur;

    void Start()
    {
        DoChangeColor();
    }

    public void DoChangeColor()
    {
        msr.material.color = new Color(Random.Range(0.f,1.0f))
    }
}
