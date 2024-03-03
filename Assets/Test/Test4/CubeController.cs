using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float v,a,n,r;
    public float vDefault;
    public Transform aPoint, bPoint;
    private Transform transform, target;
    private float timer ;
    private bool huong;
    private int count;
    private Vector3 axis;
    // huong = true cube di chuyen tu A toi B 
    // huong = false cube di chuyen tu B toi A
    private void Awake()
    {
        transform = gameObject.transform;
        transform.position = aPoint.position;
        timer = 0;
        huong = true;
        target = bPoint;
        count = 0;
        aPoint.LookAt(bPoint);
    }
    private void Update()
    {
        timer += Time.deltaTime;

        //Debug.Log(Time.deltaTime);

        //// A. di chuyen deu voi van toc v
        //transform.position = Vector3.MoveTowards(transform.position, bPoint.position, v * Time.deltaTime);
        //float currentS = a * timer * timer;

        //// B. di chuyen voi gia toc a
        //float nextS = a * timer * timer;
        //transform.position = Vector3.MoveTowards(transform.position, bPoint.position, nextS-currentS);

        //// C.Di chuyen deu tu A den B roi quay lai A, lap lai nhu vay n lan
        //transform.position = Vector3.MoveTowards(transform.position, target.position, vDefault* Time.deltaTime);
        //if (Vector3.Distance(transform.position, target.position) < 0.005&& count!= n) 
        //{
        //    target = (huong) ? aPoint : bPoint;
        //    count += (huong) ? 0 : 1;
        //    if (count == n) {
        //        target = transform;
        //    }
        //    huong = !huong;
        //}

        // D. di chuyen theo animaitoncurve
        // bat component animaiton de xem

        // E. Di chuyen object Cube quay quanh A theo truc tao boi vector AB voi van toc v,
        // ban kinh r, object Cube luon huong truc Y ve A khi quay.
        float angle = Time.time * v/r;
        Vector3 localPositionOnCircle = new Vector3(Mathf.Sin(angle) * r, Mathf.Cos(angle) * r,0f);
        Vector3 worldPositionOnCircle = aPoint.TransformPoint(localPositionOnCircle);
        transform.position = worldPositionOnCircle;
        transform.LookAt(aPoint, Vector3.right);
    }
}
