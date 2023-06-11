using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selected : MonoBehaviour
{
    [SerializeField] int option_number;
    [SerializeField] task_manag task;
    [SerializeField] TaskPollNew tp;

    private float val;
    private string explain;
    public void OnMouseDown()
    {
        if (!task.click)
        {
            task.selcted_option = option_number;
            task.option_value = val;
            task.click = true;
            tp.setText(explain);
        }
    }
    public void setVal(float value) { val = value; }
    public void setEx(string expl) { explain = expl; }
}
