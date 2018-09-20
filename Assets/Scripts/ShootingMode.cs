using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMode : MonoBehaviour {
    [SerializeField]
    private float fireRate;
    [SerializeField]
    private float shotCost;

    public float getShotCost()
    {
        return shotCost;
    }

    public float getFireRate()
    {
        return fireRate;
    }

    virtual public void Shoot()
    {

    }
}
