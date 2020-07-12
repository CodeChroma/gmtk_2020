using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject[] laserPrefabs;
    private int currentLaser;

    public float shotForce = 20f;

    void Start()
    {
        currentLaser = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetKeyDown("f"))
        {
            SwapWeapon();
        }
    }

    void SwapWeapon()
    {
        currentLaser = (currentLaser + 1) % laserPrefabs.Length;
    }

    void Shoot() 
    {
        GameObject shot = Instantiate(laserPrefabs[currentLaser], firePoint.position, firePoint.rotation);
        Rigidbody2D rigidbody = shot.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(firePoint.up * shotForce, ForceMode2D.Impulse);
    }
}
