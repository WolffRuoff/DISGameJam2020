using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public Transform player;
    public float offsetX;
    public float offsetY;

    TextMesh text;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TextMesh>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = player.position.x + offsetX;
        pos.y = player.position.y + offsetY;
        transform.position = pos;

        text.text = ""+(Time.time - startTime);
    }
}
