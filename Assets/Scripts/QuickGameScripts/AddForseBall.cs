using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForseBall : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
         rb = GetComponent<Rigidbody>();
    }
    public void AddForse()
    {
        rb.AddForce(-transform.forward * 500);
        rb.useGravity = true;
    }
    private void OnMouseDown()
    {
        rb.AddForce(transform.forward * 1000);
        rb.useGravity = true;
    }
}
