using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_animate : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = op; //hvilke vej peger figurern
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ned;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = venstre;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = højre;
        }

    }
}
