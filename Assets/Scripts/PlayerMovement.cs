using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    private float horizontal;
    private float vertical;
    public bool HasKey = false;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * horizontal * moveSpeed * Time.deltaTime);

        vertical = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector2.up * vertical * moveSpeed * Time.deltaTime);

    }

    public void GetKey()
    {
        HasKey = true;
    }
}
