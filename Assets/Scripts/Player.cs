using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * 2);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -2);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.up * 5, ForceMode2D.Impulse);
        }
    }
}
