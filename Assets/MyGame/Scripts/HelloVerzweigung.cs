using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVerzweigung : MonoBehaviour
{
    private bool a;
    private bool b;
    // Start is called before the first frame update
    void Start()
    {

        if (a)
        {
            Debug.Log("stimmt");
            return;
        }
        else
        {
            Debug.Log("stimmt nicht");
            return;
        }

        if (a)
        {
            if (b)
            {
                //same as (a && b)
            }
        }

        if (a && b)
        {
            //same as (a) & (b)
        }

        int i = 0;
        switch (i)
        {
            case 0: break;
            case 1: break;
            default:;

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
