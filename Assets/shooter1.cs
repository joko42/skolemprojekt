using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter1 : MonoBehaviour
{
    public GameObject bullet;
    public int speed;
    public Vector2 dir;
    public float rotationX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject tmp = Instantiate(bullet,transform.position+new Vector3(dir.x,dir.y,0)*1,Quaternion.identity); //set GameObject tmp til bullet
            tmp.transform.localRotation = Quaternion.Euler(0, 0, rotationX); //set rotation
            tmp.GetComponent<Rigidbody2D>().velocity = dir * speed*speed * Time.deltaTime;
            
        }
    }
}
