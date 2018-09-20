using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBulletGun : MonoBehaviour
{


    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire = 0f;
 
    public void Shoot()
    {
        if (Time.time > nextFire )
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }


}
