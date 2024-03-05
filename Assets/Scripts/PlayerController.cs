using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    public float xInput;
    public float zInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            ProcessInputs();
    }
    private void FixedUpdate() {
        Move();
    }
    private void ProcessInputs() {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

              transform.Rotate(-zInput, 0f, xInput, Space.World);
    }
    private void Move() {
        rb.AddForce(new Vector3(xInput , 0, zInput) * moveSpeed);
    }
}
