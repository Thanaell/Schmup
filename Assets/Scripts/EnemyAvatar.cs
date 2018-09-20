using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAvatar : BaseAvatar {
    [SerializeField]
    private int value;
    private GController myGameScript;

	// Use this for initialization
	void Start () {
        currentHealth = MaximumHealthPoint;
        myGameScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GController>();
    }
	


    override public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Instantiate(deathExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            myGameScript.AddScore(value);
        }
        else
        {
            Instantiate(smallExplosion, transform.position, transform.rotation);
        }

    }
}
