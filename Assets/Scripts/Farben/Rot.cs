using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour
{
    public Farbewert FWert;
    public int RWert = 1;
    public void Update()
    {

        if (FWert.RFarbe >= RWert)
        {
            gameObject.SetActive(false);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        FWert.Farbe += RWert;
        FWert.RFarbe += RWert;
    }
}

