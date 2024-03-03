using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public Color[] colors;

    public GameObject[] cubes;

    public void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            cubes[i].GetComponent<Renderer>().material.color = colors[i];
        }
    }
}
