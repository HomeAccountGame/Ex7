using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_manag : MonoBehaviour
{
    public int selcted_option;
    public float option_money;
    public float option_know;
    public float option_happy;

    public bool click = false;
    public bool selectOne = false;
    public string str;
    [SerializeField] GameObject task;
    [SerializeField] GameObject button;
    [SerializeField] GameObject button2;

    // Update is called once per frame
    void Update()
    {
        if (click && !selectOne)
        {
            selectOne = true;
            if (selcted_option == 1)
            {
                // Player pressed 'Y', execute action
                click = false;
                DataHolder.FloatValue += option_money;
                DataHolder.happines += option_happy;
                DataHolder.knowledge += option_know;
                DataHolder.lastTask[DataHolder.taskIndex] = "you choose "+str+string.Format("and get {0}$, {1} knowledge, {2}happy.", option_money, option_happy, option_know);
                DataHolder.taskIndex = (DataHolder.taskIndex + 1) % DataHolder.lastTask.Length;
                StartCoroutine(wait_screen());

            }
            else if (selcted_option == 2)
            {
                // Player pressed 'N', cancel action
                click = false;
                DataHolder.FloatValue += option_money;
                DataHolder.happines += option_happy;
                DataHolder.knowledge += option_know;
                DataHolder.lastTask[DataHolder.taskIndex] = "you choose " + str + string.Format("and get {0}$, {1} knowledge, {2}happy.", option_money, option_happy, option_know);
                DataHolder.taskIndex = (DataHolder.taskIndex + 1) % DataHolder.lastTask.Length;
                StartCoroutine(wait_screen());

            }
            else if (selcted_option==3)
            {
                click = false;
                DataHolder.FloatValue += option_money;
                DataHolder.happines += option_happy;
                DataHolder.knowledge += option_know;
                DataHolder.lastTask[DataHolder.taskIndex] = "you choose " + str + string.Format("and get {0}$, {1} knowledge, {2}happy.", option_money, option_happy, option_know);
                DataHolder.taskIndex = (DataHolder.taskIndex + 1) % DataHolder.lastTask.Length;
                StartCoroutine(wait_screen());
            }
        }
    }
    public void open_close()
    {
        task.SetActive(!task.activeSelf);
        button.SetActive(!button.activeSelf);
        button2.SetActive(!button2.activeSelf);
    }
    IEnumerator wait_screen()
    {
        yield return new WaitForSeconds(4.5f);
        open_close();
        selectOne = false;
    }

    public void setClick()
    {
        click = true;
    }
}
