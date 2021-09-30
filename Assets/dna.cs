using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dna : MonoBehaviour
{
    public Sprite rød;
    public Sprite grøn;
    public float tid;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changecolortored", tid);
    }

    public void changecolortored()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = rød;
        Invoke("changecolortogreen", tid);

    }
    public void changecolortogreen()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = grøn;
        Invoke("changecolortored", tid);

    }
}
