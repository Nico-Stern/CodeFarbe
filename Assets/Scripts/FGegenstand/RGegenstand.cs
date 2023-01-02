using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGegenstand : MonoBehaviour
{
    public Farbewert FWert;
    private Renderer rend;
    private Color Normal = Color.red;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Normal;
    }
    public void Update()
    {
        if (FWert.Farbe == 1)
        {
            GetComponent<Collider2D>().enabled = false;
        }
        if (FWert.Farbe != 1)
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
