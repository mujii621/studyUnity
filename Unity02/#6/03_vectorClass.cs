using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = new Vector2(4.0f, 3.0f);
        pos.x += 5.0f;
        pos.y += 4.0f;
        Debug.Log(pos);

        Vector2 startPos = new Vector2(4.0f, 3.0f);
        Vector2 endPos = new Vector2(9.0f, 7.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
