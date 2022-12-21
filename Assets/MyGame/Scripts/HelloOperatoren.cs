using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GleichheitsOperatoren(5, 5);
        GleichheitsOperatoren(3, 5);
        VergleichsOperatoren(4, 7);
        VergleichsOperatoren(6, 2);
        ArithmetischeOperatoren(1, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GleichheitsOperatoren(int x, int y)
    {
        if (x == y)
        {
            Debug.Log("x und y gleich " + x + " " + y);
        }


        if (x != y)
        {
            Debug.Log("x und y ungleich " + x + " " + y);
        }
    }


    private void VergleichsOperatoren(int x, int y)
    {
        if (x < y)
        {
            Debug.Log("y größer x " + x + " " + y);
        }


        if (x > y)
        {
            Debug.Log("x größer y " + x + " " + y);
        }
    }

    private void ArithmetischeOperatoren(int x, int y)
    {
        y++;
        Debug.Log(y);

        //Zuweisungsoperatoren werden bei Variablen deklaration verwendet
        x = 3;
        Debug.Log(x);
    }
}