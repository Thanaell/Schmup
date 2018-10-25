using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputController : MonoBehaviour {
    private float buttonCooler = 0.4f;
    private int buttonCount = 0;
    private BulletGun myBulletGun;
    private Engine myEngine;
	// Use this for initialization
	void Start () {
        myBulletGun = GetComponent<BulletGun>();
        myEngine = GetComponent<Engine>();
 
    }

    // Update is called once per frame
    void Update () {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        myEngine.move(moveHorizontal, moveVertical);

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

  
        //gestion de l'esquive sur double tap

        //if (Input.GetKeyDown("left"))
        //{
        //    if (buttonCooler >0 && buttonCount == 1)
        //    {
        //        myEngine.Dash();
        //    }
        //    else
        //    {
        //        buttonCooler = 0.5f;
        //        buttonCount++;

        //    }
        //}
        //if (buttonCooler > 0)
        //{
        //    buttonCooler -= Time.deltaTime;
        //}
        //else
        //{
        //    buttonCount = 0;
        //}
	}

 
}
