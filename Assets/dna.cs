using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dna : MonoBehaviour
{
    public Sprite r�d;
    public Sprite gr�n;
    public float tid;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changecolortored", tid);
    }

    public void changecolortored()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = r�d;
        Invoke("changecolortogreen", tid);

    }
    public void changecolortogreen()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = gr�n;
        Invoke("changecolortored", tid);

    }
}
