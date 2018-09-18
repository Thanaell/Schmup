using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public int value;
    private GController myGameController;
    private GameObject myPlayer;
    public int damage;

    void Start()
    {
        myPlayer = GameObject.FindWithTag("Player");
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            myGameController = gameControllerObject.GetComponent <GController>();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag=="Ennemy" || other.tag=="EnnemyBolt")
        {
            return;
        }

        if (other.tag == "Player")
        {
            if (explosion != null)
            {
                Instantiate(explosion, transform.position, transform.rotation);
            }
            myPlayer.GetComponent<PlayerAvatar>().TakeDamage(damage);
            Destroy(gameObject);
          
        }
        else
        {
            Instantiate(explosion, transform.position, transform.rotation);
            myGameController.AddScore(value);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
     
    }
}

