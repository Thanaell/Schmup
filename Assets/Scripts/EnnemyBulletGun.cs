using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBulletGun : MonoBehaviour
{
    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private Transform shotSpawn;
    [SerializeField]
    private float fireRate;

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
