using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerTBS : MonoBehaviour
{
    public static PlayerTBS singleton;
    private Rigidbody rb;
    public Vector3 _newPosition;
    void Start()
    {
        singleton = this;
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(rb.velocity.normalized.y > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                transform.DOMove(_newPosition, 0.5f);
            }
        }
    }


}
