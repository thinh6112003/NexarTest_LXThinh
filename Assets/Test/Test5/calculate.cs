using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculate : MonoBehaviour
{
    public Transform A, B;
    void Start()
    {
        Vector3 localPosition = B.InverseTransformPoint(A.position);
        Debug.Log("local Position of A vs B: " + localPosition);
    }
}
