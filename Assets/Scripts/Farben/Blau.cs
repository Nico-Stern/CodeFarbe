using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blau : MonoBehaviour
{
    public Farbewert FWert;
    public int BWert = 2;


    public void Update()
    {
        if (FWert.Farbe >= BWert)
        {
            gameObject.SetActive(false);
        }
        if (FWert.Farbe < 2)
        {
            gameObject.SetActive(true);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        FWert.Farbe += BWert;
        FWert.BFarbe += BWert;
    }
}
