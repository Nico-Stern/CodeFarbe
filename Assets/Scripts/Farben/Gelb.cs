using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gelb : MonoBehaviour
{
    public Farbewert FWert;
    public int GWert = 4;


    public void Update()
    {
        if (FWert.Farbe >= GWert)
        {
            gameObject.SetActive(false);
        }
        if (FWert.Farbe < 4)
        {
            gameObject.SetActive(true);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        FWert.Farbe += GWert;
        FWert.GFarbe += GWert;
    }
}
