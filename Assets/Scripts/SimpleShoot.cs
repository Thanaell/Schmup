using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : ShootingMode {
    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private Transform shotSpawn;

    override public void Shoot()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }
}
