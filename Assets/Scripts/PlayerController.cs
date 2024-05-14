using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    GameObject focalPoint;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    void Update()
    {
        float forwardInput = Input.GetAxisRaw("Vertical");
        rb.AddForce(focalPoint.transform.forward * forwardInput * speed);
    }
}
