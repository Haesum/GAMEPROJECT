using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubejump : MonoBehaviour
{
    public Collider sprite;
    public float jumpforce = 10f;
    Rigidbody2d rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2d>();
    }

    void Update()
    {
        bool collision = true;

        if (collision && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode.Impulse);
        }
    }
}
