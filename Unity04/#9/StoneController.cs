using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos, endPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;
            float swipeLength = (this.endPos.y - this.startPos.y);
            this.speed = swipeLength / 400.0f;
        }

        transform.Translate(0, this.speed, 0);
        this.speed *= 0.95f;

        //if (this.speed < 0.01f)
        //{
        //    this.speed = 0;
        //}
    }
}
