using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : ShootingMode {

    public GameObject shot;
    public Transform shotSpawn;

    override public void Shoot()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }
}
