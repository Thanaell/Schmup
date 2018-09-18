using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public int value;
    private GController myGameController;

    void Start()
    {
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

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            myGameController.GameOver();
        }
        else
        {
            myGameController.AddScore(value);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}

