using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    float timeLeft;
    Color targetColor;
    SpriteRenderer rend;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        targetColor = Color.Lerp(rend.material.color, new Color(Random.value, Random.value, Random.value, 0.7f), Time.deltaTime / timeLeft);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            // transition complete
            // assign the target color
            rend.material.color = targetColor;

            // start a new transition
            targetColor = new Color(Random.value, Random.value, Random.value, 0.7f);
            timeLeft = 4.0f;
        }
        else
        {
            // transition in progress
            // calculate interpolated color
            rend.material.color = Color.Lerp(rend.material.color, targetColor, Time.deltaTime / timeLeft);

            // update the timer
            timeLeft -= Time.deltaTime;
        }
    }
}
