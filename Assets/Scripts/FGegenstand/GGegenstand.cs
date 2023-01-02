using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGegenstand : MonoBehaviour
{
    public Farbewert FWert;
    private Renderer rend;
    private Color Normal = Color.yellow;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Normal;
    }
    public void Update()
    {
        if (FWert.Farbe == 4)
        {
            GetComponent<Collider2D>().enabled = false;
        }
        if (FWert.Farbe != 4)
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
