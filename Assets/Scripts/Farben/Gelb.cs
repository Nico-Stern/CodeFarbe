using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gelb : MonoBehaviour
{
    public Farbewert FWert;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        FWert.Farbe += 4;
    }
}