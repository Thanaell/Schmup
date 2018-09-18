using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour {


    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire = 0f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    public void Shoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
