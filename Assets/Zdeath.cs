using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zdeath : MonoBehaviour
{
    public GameObject død;
    public GameObject dna;
    public float newYPos;
    Vector3 dnapos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == ("bullet"))
        {
            dnapos.x= Random.Range(-0.1f, 0.1f);
            dnapos.y = Random.Range(-0.1f, 0.1f)+newYPos;
            GameObject tmp = Instantiate(død, transform.position, Quaternion.identity);
            Instantiate(dna, transform.position + dnapos, Quaternion.identity);
            Destroy(gameObject);
            Destroy(tmp, 2f);
        }
    }
}
