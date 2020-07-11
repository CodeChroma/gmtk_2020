using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed= 5f;

    new public Rigidbody2D rigidbody;
    new public Camera camera;

    Vector2 movement;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 faceDirection = mousePos - rigidbody.position;
        float angle = Mathf.Atan2(faceDirection.y, faceDirection.x) * Mathf.Rad2Deg - 90f;
        rigidbody.rotation = angle;
    }
}