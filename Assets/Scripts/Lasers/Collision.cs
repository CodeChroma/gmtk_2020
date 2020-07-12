using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject hitEffect;

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(hitEffect, 5f);
        Destroy(gameObject);
    }
}
