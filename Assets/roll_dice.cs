using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll_dice : MonoBehaviour
{
    GameObject dice1;
    GameObject dice2;
    GameObject pl;

    mover mov;
    GameObject mange;
    //GameObject sts;
    Roll dice1_roll;
    Roll dice2_roll;
    //turn_handler handler;
    private int steps = 0;
    private int locatiion = 0;
    string currTurn = "player1";

    // Start is called before the first frame update
    void Start()
    {
        dice1 = GameObject.Find("dice1");
        dice2 = GameObject.Find("dice2");
        pl = GameObject.Find("Player");
        mange = GameObject.Find("Maneger");


        dice1_roll = dice1.GetComponent<Roll>();
        dice2_roll = dice2.GetComponent<Roll>();
        mov = mange.GetComponent<mover>();

    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        StartCoroutine(move());
    }

    IEnumerator move()
    {
        dice1_roll.StartCoroutine("RollTheDice");
        yield return dice2_roll.StartCoroutine("RollTheDice");
        steps = dice1_roll.getVal() + dice2_roll.getVal();
        
        Debug.Log("start moveing");

        mov.StartCoroutine("moveplayer");
      
        //sts = GameObject.Find("steps");
        //steps st = sts.GetComponent<steps>();
        //st.moveplayer();
        //handler.nextTurn();
    }

    public int getSteps() { return steps; }
    public string getCurrTurn() { return currTurn; }




}
