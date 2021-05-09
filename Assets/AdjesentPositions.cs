using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjesentPositions : MonoBehaviour
{
    private Rigidbody rb;
    public Material materialDefault;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.normalized.y > 0)
        {
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(rb.velocity.normalized.y > 0 && other.TryGetComponent(out JumpPosition jumpPos))
        {
            jumpPos.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out JumpPosition jumpPos))
        {
            jumpPos.GetComponent<Renderer>().material.color = materialDefault.color;
        }
    }
}
