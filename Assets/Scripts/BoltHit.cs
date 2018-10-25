using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltHit : MonoBehaviour {
    [SerializeField]
    private float myDamage;
	
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
