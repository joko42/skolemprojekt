using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public int player1, player2;
    public Text player1Score, player2Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1Score.text = "Player 1: "+player1.ToString() + "/100" ;
        player2Score.text = "Player 2: " + player2.ToString() + "/100";
    }
}
