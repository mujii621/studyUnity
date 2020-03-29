using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SayOssan("夢爺");
    }

    void SayOssan(string name)
    {
        if (CheckAge(40))
        {
            Debug.Log(name + "はおっさん！！");
        }
        else
        {
            Debug.Log(name + "はおっさんじゃない！！");
        }
    }

    bool CheckAge(int age)
    {
        if (age >= 40)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
