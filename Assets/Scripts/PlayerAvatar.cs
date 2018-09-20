using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class PlayerAvatar : BaseAvatar {
    private GController myGameControllerScript;
    [SerializeField]
    private float maxEnergy;
    private float energy;
    [SerializeField]
    private float energyGain;
    private Slider energySlider;
    private Slider healthSlider;
    private bool isEnergyDrained = false;

    // Use this for initialization
    void Start () {
        myGameControllerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GController>();
        currentHealth = MaximumHealthPoint;
        energy = maxEnergy;
        currentHealth = MaximumHealthPoint;
        energySlider = GameObject.Find("Canvas/EnergySlider").GetComponent<Slider>();
        energySlider.minValue = 0;
        energySlider.maxValue = maxEnergy;
        healthSlider = GameObject.Find("Canvas/HealthSlider").GetComponent<Slider>();
        healthSlider.minValue = 0;
        healthSlider.maxValue = MaximumHealthPoint;
        healthSlider.value = currentHealth;
    }
	
	// Update is called once per frame
	void UpdateSlider () {
        energySlider.value = energy;
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
        healthSlider.value = currentHealth;
    }

    public bool IncreaseEnergy(float actionCost)
    {
        if (energy + energyGain >= maxEnergy)
        {
            energy = maxEnergy;
            UpdateSlider();
            isEnergyDrained = false;
            return true;
        }
        else
        {
            energy += energyGain;
            UpdateSlider();
            if (energy >= actionCost)
            {
                if (isEnergyDrained)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        
    }

    public bool DecreaseEnergy(float actionCost)
    {
        if (energy - actionCost <= 0)
        {
            energy = 0;
            UpdateSlider();
            isEnergyDrained = true;
            return false;
        }
        else
        {
            energy -= actionCost;
            UpdateSlider();
            return true;
        }
    }
    
}
