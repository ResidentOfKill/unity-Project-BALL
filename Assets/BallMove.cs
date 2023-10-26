using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    [SerializeField] private float ballforce = 1f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Input.GetAxisRaw("Horizontal") * ballforce,0,Input.GetAxisRaw("Vertical") * ballforce);
    }
}
