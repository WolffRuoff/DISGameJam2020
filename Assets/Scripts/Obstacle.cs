using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float YMin;
    public float YMax;
    public float XMin;
    public float XMax;


    void Start()
    {
        Transform needle1 = gameObject.transform.GetChild(2);
        Transform needle2 = gameObject.transform.GetChild(3);
        Transform needle3 = gameObject.transform.GetChild(4);

        float x1 = needle1.position.x + Random.Range(XMin, XMax);
        float y1 = needle1.position.y + Random.Range(YMin, YMax);
        float x2 = needle2.position.x + Random.Range(XMin, XMax);
        float y2 = needle2.position.y + Random.Range(YMin, YMax);
        float x3 = needle3.position.x + Random.Range(XMin, XMax);
        float y3 = needle3.position.y + Random.Range(YMin, YMax);

        needle1.position = new Vector3(x1, y1, 1);
        needle2.position = new Vector3(x2, y2, 1);
        needle3.position = new Vector3(x3, y3, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
