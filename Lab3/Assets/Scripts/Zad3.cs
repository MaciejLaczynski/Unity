using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3 : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.2f;
    public float move_distance;
    void Update()
    {
        if (move_distance >= 10)
        {
            move_distance = 0;
            transform.Rotate(0, 90, 0);
        }
        move_distance += speed;
        transform.position += transform.forward * speed;
    }
}