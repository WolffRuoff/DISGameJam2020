using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slope : MonoBehaviour
{

    public GameObject button;
    public GameObject denim;

    private GameObject lastObj;
    private int prevX;

    // Start is called before the first frame update
    void Start()
    {
        lastObj = denim;
        prevX = -10;
    }

    // Update is called once per frame
    void Update()
    {
        if ((int) button.transform.position.x % 15 == 0 && (int)button.transform.position.x > prevX)
        {
            prevX = (int)button.transform.position.x;

            // get current button position and keep rotation constant
            Vector3 pos = lastObj.transform.position;
            pos.x += 15;
            pos.y -= 8f;
            Quaternion rot = denim.transform.rotation;

            lastObj = Instantiate(denim, pos, rot);
        }
    }

}
