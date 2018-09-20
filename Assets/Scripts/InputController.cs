using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    private BulletGun myBulletGun;
    private Engine myEngine;
	// Use this for initialization
	void Start () {
        myBulletGun = GetComponent<BulletGun>();
        myEngine = GetComponent<Engine>();
	}
	
	// Update is called once per frame
	void Update () {
      
        if (Input.GetKey("space"))
        {
            myBulletGun.Shoot();
        }
        else
        {
            myBulletGun.Wait();
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            myBulletGun.SwitchShootingMode();
        }
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        myEngine.move(moveHorizontal, moveVertical);
    }
}
