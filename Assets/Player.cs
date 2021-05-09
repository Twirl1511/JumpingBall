using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [SerializeField] private float _force;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.left);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.back);
        }
    }

    private void Move(Vector3 direction)
    {
        rb.AddForce(direction * _force * Time.deltaTime, ForceMode.Impulse);
    }
}
