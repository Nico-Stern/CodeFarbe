using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blau : MonoBehaviour
{
    public Farbewert FWert;
    public int BWert = 2;


    public void Update()
    {
        if (FWert.BFarbe >= BWert)
        {
            gameObject.SetActive(false);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        FWert.Farbe += BWert;
        FWert.BFarbe += BWert;
    }
}
