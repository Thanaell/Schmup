using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAvatar : MonoBehaviour {
    [SerializeField]
    private float damageDealt;
    [SerializeField]
    protected GameObject deathExplosion;
    [SerializeField]
    protected GameObject smallExplosion;
    protected float currentHealth;
    [SerializeField]
    private float maximumHealthPoint;

    public float MaximumHealthPoint
    {
        get
        {
            return this.maximumHealthPoint;
        }
        private  set
        {
           this.maximumHealthPoint = value ;
        }
     }
    // Use this for initialization
    void Start () {
        currentHealth = MaximumHealthPoint;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(this.GetType());
	}


     virtual public void TakeDamage(float damage)
    {
        Debug.Log("bonjour");
    }

    public float getDamageDealt()
    {
        return damageDealt;
    }
}
