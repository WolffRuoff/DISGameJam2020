using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public GameObject score;
    public float offsetX;
    public float offsetY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TextMesh t = score.GetComponent<TextMesh>();
        Vector3 pos = transform.position;
        pos.x = score.transform.position.x - GetWidht(t);
        pos.y = score.transform.position.y;
        transform.position = pos;
        GetComponent<TextMesh>().text = "Score: ";
    }

    public static float GetWidht(TextMesh mesh)
    {
        float width = 0;
        foreach (char symbol in mesh.text)
        {
            CharacterInfo info;
            if (mesh.font.GetCharacterInfo(symbol, out info))
            {
                width += info.width;
            }
        }
        return width * mesh.characterSize * 0.1f * mesh.transform.lossyScale.x;
    }
}

