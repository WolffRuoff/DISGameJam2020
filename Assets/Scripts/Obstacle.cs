using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject needleObstacle;

    public float YMin;
    public float YMax;
    public float XMin;
    public float XMax;


    void Start()
    {
        spawnObj(true);
        spawnObj(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnObj (bool first)
    {
        float x;
        float y = Random.Range(YMin, YMax);
        float mdpt = (XMin + XMax) / 2;

        if (first)
        { 
            x = Random.Range(XMin, mdpt);
            y = 3;
        } else
        {
            x = Random.Range(mdpt, XMax);
            y = 1;
        }

        Vector3 spawnPos = transform.position;
        spawnPos.x += x;
        spawnPos.y += y;

        Instantiate(needleObstacle, spawnPos, Quaternion.identity);
    }
    
}
