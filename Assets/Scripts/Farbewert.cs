using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farbewert : MonoBehaviour
{
    public Rot Rot;
    public Blau Blau;
    public Gelb Gelb;
    public int Farbe = 0;

    public void Update()
    {
        switch(Farbe)
        {
            case 1:
                print("Rot");
                break;

            case 2:
                print("Blau");
                break;

            case 3:
                print("lila");
                break;

            case 4:
                print("Gelb");
                break;

            case 5:
                print("Orange");
                break;

            case 6:
                print("Grün");
                break;

            case 7:
                print("Schwarz");
                break;

            default:
                
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Eimer"))
        {

        }
    }
}
