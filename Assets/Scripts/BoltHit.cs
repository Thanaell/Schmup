using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltHit : MonoBehaviour {
    public float myDamage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if ((tag=="Bolt" && other.tag == "Ennemy") || (tag=="EnnemyBolt" && other.tag=="Player"))
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<BaseAvatar>().TakeDamage(myDamage);
        }
        if (tag=="Bolt" && other.tag == "EnnemyBolt")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
