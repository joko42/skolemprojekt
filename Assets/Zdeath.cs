using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zdeath : MonoBehaviour
{
    public Sprite d�d;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == ("bullet"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = d�d;
        }
    }
}
