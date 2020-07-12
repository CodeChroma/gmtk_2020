using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject shotPrefab;

    public float shotForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot() 
    {
        GameObject shot = Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigidbody = shot.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(firePoint.up * shotForce, ForceMode2D.Impulse);
    }
}
