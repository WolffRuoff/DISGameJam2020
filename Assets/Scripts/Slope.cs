using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slope : MonoBehaviour
{

    public GameObject button;
    public GameObject denim;

    private GameObject lastObj;

    // Start is called before the first frame update
    void Start()
    {
        lastObj = denim;
    }

    // Update is called once per frame
    void Update()
    {
        if ((int) button.transform.position.x % 10 == 0)
        {
            // get current button position and keep rotation constant
            Vector3 pos = lastObj.transform.position;
            pos.x += 10;
            pos.y -= 6.3f;
            Quaternion rot = denim.transform.rotation;

            lastObj = Instantiate(denim, pos, rot);
        }
    }
}
