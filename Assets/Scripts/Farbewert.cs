using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farbewert : MonoBehaviour
{
    public Weiﬂ Weiﬂ;
    public Rot Rot;
    public Blau Blau;
    public Gelb Gelb;
    public int Farbe = 0;
    public int RFarbe;
    public int BFarbe;
    public int GFarbe;
    public int WFarbe;
    private Renderer rend;
    private Color FColor = Color.white;
    private Color Lila = new Color(0.5f, 0.2f, 0.8f, 0.6f);
    private Color Orange = new Color(0.9f, 0.4f, 0.2f);

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void Update()
    {
        rend.material.color = FColor;
        switch (Farbe)
        {
            case <0:
                FColor= Color.white;
                Farbe = 0;
                break;
            case 1:
                FColor = Color.red;            
                    break;

            case 2:
                FColor = Color.blue;
                break;

            case 3:
                FColor = Lila;
                break;

            case 4:
                FColor = Color.yellow;
                break;

            case 5:
                FColor = Orange;
                break;

            case 6:
                FColor = Color.green;
                break;

            case 7:
                FColor = Color.black;
                break;

            default:
                FColor= Color.white;               
                break;
        }
    }
}
