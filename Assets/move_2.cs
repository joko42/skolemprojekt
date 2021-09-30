using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_2 : MonoBehaviour
{
    public float speed;
    public shooter2 gun; //laver info fra shooter1 script om til gun info
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
            gun.dir = new Vector2(0, 1); //skudretning
            gun.rotationX = 90; //skudet rotation
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
            gun.dir = new Vector2(0, -1);
            gun.rotationX = -90; //skudet rotation
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
            gun.dir = new Vector2(-1, 0);
            gun.rotationX = 180; //skudet rotation
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            gun.dir = new Vector2(1, 0);
            gun.rotationX = 0; //skudet rotation
        }

    }
}
