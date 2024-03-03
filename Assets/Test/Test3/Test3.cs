using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{

    public Enemy enemy;

    public void Start()
    {
        Destroy(enemy);
    }

    public void Update()
    {
        FunctionA();
        //FunctionB();
    }

    public void FunctionA()
    {
        enemy.health = 5;
    }

    private void FunctionB()
    {
        enemy.name = "....";
    }
}
