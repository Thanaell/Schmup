using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAvatar : MonoBehaviour {
    public float damageDealt;
    public GameObject deathExplosion;
    public GameObject smallExplosion;
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

	}

    public float getCurrentHealth()
    {
        return currentHealth;
    }
     virtual public void TakeDamage(float damage)
    {
        Debug.Log("bonjour");
    }
}
