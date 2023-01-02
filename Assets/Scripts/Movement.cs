using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float vertical;
    public float horizontal;
    public float speed = 5f;
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector2 MovementH = Vector2.right * horizontal * speed * Time.deltaTime;
        transform.Translate(MovementH);
        Vector2 MovementV = Vector2.up * vertical * speed * Time.deltaTime;
        transform.Translate(MovementV);      
    }
}
