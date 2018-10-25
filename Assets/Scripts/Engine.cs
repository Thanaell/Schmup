using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class Engine : MonoBehaviour {
    [SerializeField]
    private float speed;
    [SerializeField]
    private float tilt;
    [SerializeField]
    private Boundary boundary;

    public void move(float moveHorizontal, float moveVertical)
    {
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.position = transform.position + movement * speed *Time.deltaTime;
        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(transform.position.z, boundary.zMin, boundary.zMax)
        );

        transform.rotation = Quaternion.Euler(0.0f, 0.0f, moveHorizontal * -tilt);
    }


    public void Dash()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x - 2, boundary.xMin, boundary.xMax), transform.position.y, transform.position.z);
    }

}
