using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloVariablen : MonoBehaviour
{
    //Value Types: Wert wird im Speicher direkt hinterlegt
    int myInt = 0;
    bool myBool = true;
    string a = "hallo";

    int[] myArray = new int[3] { 0, 0, 0 };
 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        int temp = myInt;
        myInt = myInt++;
        Debug.Log("myInt: " + myInt + "temp: " + temp);

        int[] tmpArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        foreach (int a in tmpArray)
        {
            Debug.Log(a);
        }

        foreach (int a in myArray)
        {
            Debug.Log(a);
        }

        string tmpString = a;
        a = "hello";
        Debug.Log("a" + a + "tmp String" + tmpString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
