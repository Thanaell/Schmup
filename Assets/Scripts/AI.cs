using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    private Engine myEngine;
    private EnnemyBulletGun myBulletGun;

	// Use this for initialization
	void Start () {
        myEngine = GetComponent<Engine>();
        myBulletGun = GetComponent<EnnemyBulletGun>();
    }
	
	// Update is called once per frame
	void Update () {
        myEngine.move(0.0f, -1f);
        myBulletGun.Shoot();
	}

}
