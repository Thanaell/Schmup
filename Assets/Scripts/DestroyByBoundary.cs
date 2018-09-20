using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyByBoundary : MonoBehaviour
{
    [SerializeField]
    private int value;
    private GController myGameController;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            myGameController = gameControllerObject.GetComponent<GController>();
        }
    }
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        if (other.tag != "Bolt" && other.tag !="EnnemyBolt")
        {
            myGameController.AddScore(value);
        }
    }
}