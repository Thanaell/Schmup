using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralShoot : ShootingMode {

    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private Transform shotSpawn;



    override public void Shoot()
    {
        shotSpawn.Rotate(0, 20, 0);
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        shotSpawn.Rotate(0, 20, 0);
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        shotSpawn.Rotate(0, 20, 0);
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        shotSpawn.Rotate(0, -60, 0);
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        shotSpawn.Rotate(0, -20, 0);
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        shotSpawn.Rotate(0, -20, 0);
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        shotSpawn.Rotate(0, -20, 0);
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        shotSpawn.Rotate(0, 60, 0);

    }
}
