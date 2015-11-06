using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{
    public GameObject bullet;   
    public Transform ShotSpawner;
    private float fireRate = 0.1f;
    private float nextFire = 0.1f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)

        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, ShotSpawner.position, ShotSpawner.rotation);
        }
    }
}
