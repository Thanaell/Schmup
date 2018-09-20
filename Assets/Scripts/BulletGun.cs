using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour {

    public ShootingMode[] myShootingModes;
    public int indexShoot=0;


    private float nextFire = 0f;
    private PlayerAvatar myPlayer;
    private bool canShoot;

    // Use this for initialization
    void Start () {
        myPlayer = gameObject.GetComponent<PlayerAvatar>();
        canShoot = true;
    }

    public void Wait()
    {
        canShoot = myPlayer.IncreaseEnergy();
    }

    public void Shoot()
    {
        
        if (Time.time > nextFire && canShoot)
        {
            nextFire = Time.time + myShootingModes[indexShoot].fireRate;
            myShootingModes[indexShoot].Shoot();
            canShoot = myPlayer.DecreaseEnergy();
        }
        else if(!canShoot)
        {
            Wait();
        }
    }

    public void SwitchShootingMode()
    {
        indexShoot = (indexShoot + 1) % myShootingModes.Length;
    }


}
