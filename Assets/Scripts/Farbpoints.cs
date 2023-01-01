using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Farbpoints : MonoBehaviour
{
    public Farbewert FWert;
    public int Farbpoint = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        FWert.Farbe += 2;
    }
}
