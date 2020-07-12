using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject hitEffect;

    public AudioSource source;

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        hitEffect = (GameObject) Instantiate(hitEffect, transform.position, Quaternion.identity);
        source.Play();
        Destroy(hitEffect, 2f);
        Destroy(gameObject);
    }
}
