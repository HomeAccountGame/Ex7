using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_manag : MonoBehaviour
{
    public int selcted_option;
    public float option_value;
    public bool click = false;
    [SerializeField] GameObject task;
    [SerializeField] GameObject button;

    // Update is called once per frame
    void Update()
    {
        if (click)
        {

            if (selcted_option == 1)
            {
                // Player pressed 'Y', execute action
                click = false;
                DataHolder.FloatValue += option_value;
                StartCoroutine(wait_screen());

            }
            else if (selcted_option == 2)
            {
                // Player pressed 'N', cancel action
                click = false;
                DataHolder.FloatValue += option_value;
                StartCoroutine(wait_screen());

            }
            else if (selcted_option==3)
            {
                click = false;
                DataHolder.FloatValue += option_value;
                StartCoroutine(wait_screen());
            }
        }
    }
    public void open_close()
    {
        task.SetActive(!task.activeSelf);
        button.SetActive(!button.activeSelf);
    }
    IEnumerator wait_screen()
    {
        yield return new WaitForSeconds(4.5f);
        open_close();
    }
}
