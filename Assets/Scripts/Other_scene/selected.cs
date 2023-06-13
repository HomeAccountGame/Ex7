using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selected : MonoBehaviour
{
    [SerializeField] int option_number;
    [SerializeField] task_manag task;
    [SerializeField] TaskPollNew tp;

    private float val_mon;
    private float val_know;
    private float val_happ;


    private string explain;
    public void OnMouseDown()
    {
        Debug.Log(task.click);
        if (!task.click)
        {
            task.selcted_option = option_number;
            task.option_money = val_mon;
            task.option_know = val_know;
            task.option_happy = val_happ;

            task.setClick();
            task.str = explain;
            tp.setText(explain);
        }
    }
    public void setVal(float money,float know,float happy) 
    { 
        val_mon = money;
        val_know = know;
        val_happ = happy;
    }
    public void setEx(string expl) { explain = expl; }
}
