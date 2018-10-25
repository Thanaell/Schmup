using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class FloatEvent : UnityEvent<float> { }

public class PlayerAvatar : BaseAvatar {
    public FloatEvent myEvent;
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
        myEvent = new FloatEvent();
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
            myEvent.AddListener(myGameControllerScript.GameOver); //j'aimerais passer par l'éditeur, mais ça marche pas
            myEvent.Invoke(5f);
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
