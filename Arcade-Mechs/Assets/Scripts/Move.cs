using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 50f;
    public float rotationSpeed = 5f;
    private Rigidbody rb;
    private float rotSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //poppetje moet vooruit gaan
            rb.AddForce(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = Vector3.zero;
        }

        float xMove = Input.GetAxis("Horizontal");
        Debug.Log(xMove);

        transform.Rotate(transform.up, rotationSpeed * xMove);

        {
            Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
            transform.position = positionUpdate;
            transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));
        }

    }
}