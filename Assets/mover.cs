using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    GameObject[] board;
    GameObject Pla;
    MoveTo mov;
    GameObject Dice;
    roll_dice dices;
    int loc = 0;

    void Start()
    {
        Pla = GameObject.Find("Player");
        mov = Pla.GetComponent<MoveTo>();

        Dice = GameObject.Find("Dice");
        dices = Dice.GetComponent<roll_dice>();

        board = new GameObject[18];
        for (int i = 0; i < 18; i++)
        {
            string curr = "loc" + i;
            board[i] = GameObject.Find("loc" + i);
        }
    }

    public IEnumerator moveplayer()
    {
        
        int step = dices.getSteps();

        for (int i = 0; i < step; i++)
        {
            yield return new WaitForSeconds(0.5f);
            mov.setTarget(board[(i + loc) % 18].transform);
        }
        loc += step;
    }
   
}