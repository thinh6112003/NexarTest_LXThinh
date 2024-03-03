using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthA
{
    public int value;
}

public struct HealthB
{
    public float value;
}

public class Test1 : MonoBehaviour
{
    public void Start()
    {
        FunctionA();
        FunctionB();
    }

    public void FunctionA()
    {
        // healtha là class 
        HealthA a = new HealthA();
        a.value = 0;
        
        HealthA b = a;
        a.value = 1234;

        Debug.Log("funa: "+b.value);
    }

    public void FunctionB()
    {
        HealthB a = new HealthB();
        a.value = 0;

        HealthB b = a;
        a.value = 1234;

        Debug.Log("funb: " + b.value);
    }
}
