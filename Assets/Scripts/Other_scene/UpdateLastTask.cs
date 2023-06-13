using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLastTask : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject image;
    [SerializeField] UpdateText text1;
    [SerializeField] UpdateText text2;
    [SerializeField] UpdateText text3;
    [SerializeField] UpdateText text4;
    [SerializeField] UpdateText text5;
    [SerializeField] UpdateText text6;


    public void showTasks()
    {
        image.SetActive(!image.activeSelf);
        string[] tasks = DataHolder.lastTask;
        if (tasks[0]!=null)
            text1.setText(tasks[0]);
        text2.setText(tasks[1]);
        text3.setText(tasks[2]);
        text4.setText(tasks[3]);
        text5.setText(tasks[4]);
        text6.setText(tasks[5]);
    }
    public void hide()
    {
        image.SetActive(!image.activeSelf);
    }

}
