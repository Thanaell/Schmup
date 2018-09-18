using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class PlayerAvatar : BaseAvatar {
    private GController myGameControllerScript;
    private Text healthText;
    // Use this for initialization
    void Start () {
        myGameControllerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GController>();
        currentHealth = MaximumHealthPoint;
        healthText = GameObject.Find("Canvas/HealthText").GetComponent<Text>();
        healthText.text = currentHealth + " / " + MaximumHealthPoint;
    }
	
	// Update is called once per frame
	void Update () {
     
    }
    override public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        UpdateDisplayHealth();
        if (currentHealth <= 0)
        {
            Instantiate(deathExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            myGameControllerScript.GameOver();       
        }
        else
        {
            Instantiate(smallExplosion, transform.position, transform.rotation);
        }

    }

    void UpdateDisplayHealth()
    {
        if (currentHealth >= 0)
        {
            healthText.text = currentHealth + " / " + MaximumHealthPoint;
        }
        else
        {
            healthText.text = "0 /" + MaximumHealthPoint;
        }
    }
    
}
