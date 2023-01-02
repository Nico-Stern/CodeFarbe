using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Weiß : MonoBehaviour
{
    public Rot Rot;
    public Blau Blau;
    public Gelb Gelb;
    public Farbewert FWert;
    public int WWert = -10;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FWert.Farbe = 0;
        
    }
}
