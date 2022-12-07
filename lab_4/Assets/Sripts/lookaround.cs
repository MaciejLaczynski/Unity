using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookaround : MonoBehaviour
{

    public Transform player;

    public float sensitivity = 200f;

    public float minAngle = -90.0f;
    public float maxAngle = 90.0f;

    private float mouseXMove = 0.0f;
    private float mouseYMove = 0.0f;

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseXMove += sensitivity * Time.deltaTime * Input.GetAxis("Mouse X");
        mouseYMove -= sensitivity * Time.deltaTime * Input.GetAxis("Mouse Y");

        mouseYMove = Mathf.Clamp(mouseYMove, minAngle, maxAngle);

        transform.eulerAngles = new Vector3(mouseYMove, mouseXMove, 0.0f);
    }
}
