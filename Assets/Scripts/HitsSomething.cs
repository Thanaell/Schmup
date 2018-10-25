using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitsSomething : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "EnnemyBolt" || other.tag == "Bolt")
        {
            return;
        }
        else 
        {
            BaseAvatar thisAvatar = GetComponent<BaseAvatar>();
            BaseAvatar otherAvatar = other.gameObject.GetComponent<BaseAvatar>();
            thisAvatar.TakeDamage(otherAvatar.getDamageDealt());
     
        }
        
    }
}
