using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShoot : ShootingMode
{
    [SerializeField]
    private GameObject shot;
    [SerializeField]
    private Transform shotSpawn;
    override public void Shoot()
    {
        shotSpawn.Rotate(0, 25, 0);
        Instantiate(shot, shotSpawn.position + new Vector3(0.5f,0,0) , shotSpawn.rotation);
        shotSpawn.Rotate(0, -50, 0);
        Instantiate(shot, shotSpawn.position - new Vector3(0.5f, 0, 0), shotSpawn.rotation);
        shotSpawn.Rotate(0, 25, 0);
    }
}
