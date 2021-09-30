using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation1 : MonoBehaviour
{
    public Sprite højre;
    public Sprite venstre;
    public Sprite op;
    public Sprite ned;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = op; //hvilke vej peger figurern
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ned;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = venstre;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = højre;
        }

    }
}
