using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _distance;
    [SerializeField] private float _jumpForce;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveDown();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        MoveDown();
        BallJump(collision.gameObject.GetComponent<Rigidbody>(), collision); 
    }

    private void MoveDown()
    {
        float y = transform.position.y - _distance;
        transform.DOMoveY(y, 1);
    }

    private void BallJump(Rigidbody rb, Collision collision)
    {
        Vector3 dir = collision.relativeVelocity.normalized;
        if(dir.y > dir.x/2 && dir.y > dir.z/2)
        {
            dir = Vector3.up;
        }
        rb.AddForce(-dir * _jumpForce);
    }


    private void OnMouseDown()
    {
        Vector3 pos = new Vector3(transform.position.x, PlayerTBS.singleton.transform.position.y, transform.position.z);
        PlayerTBS.singleton._newPosition = pos;
    }

}
