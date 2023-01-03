using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject GRot;
    public GameObject GBlau;
    public GameObject GGelb;

    public float Rot1x = 0f;
    public float Rot1y = 0f;
    public float Rot2x = 0f;
    public float Rot2y = 0f;
    public float Rot3x = 0f;
    public float Rot3y = 0f;
    public float Blau1x = 0f;
    public float Blau1y = 0f;
    public float Blau2x = 0f;
    public float Blau2y = 0f;
    public float Blau3x = 0f;
    public float Blau3y = 0f;
    public float Gelb1x = 0f;
    public float Gelb1y = 0f;
    public float Gelb2x = 0f;
    public float Gelb2y = 0f;
    public float Gelb3x = 0f;
    public float Gelb3y = 0f;

    public void Start()
    {
        transform.position += Vector3.right * Rot1x;
        transform.position += Vector3.up * Rot1y;
        Instantiate(GRot, transform.position, Quaternion.identity);
    }

}
