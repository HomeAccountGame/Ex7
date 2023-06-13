using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]

public class Confitmation : MonoBehaviour
{
    [SerializeField]public string str;
    [SerializeField]public float sum;
    [SerializeField] Money mon;
    [SerializeField] Asset ass;

    public bool otherClick = false;
    [SerializeField] Confitmation conf1;
    [SerializeField] Confitmation conf2;

    string origin_text;

    private bool click = false;
    void Update()
    {
        if (click&&!otherClick)
        {

            if (Input.GetKey(KeyCode.Y))
            {
                // Player pressed 'Y', execute action
                ExecuteAction();
                click = false;

            }
            else if (Input.GetKey(KeyCode.N))
            {
                // Player pressed 'N', cancel action
                CancelAction();
                click = false;

            }
        }
    }
    private void OnMouseDown()
    {
        if (!otherClick)
        {
            if (conf1 != null)
            {
                conf1.otherClick = true;
            }
            if (conf2 != null)
            {
                conf2.otherClick = true;
            }
            origin_text = GetComponent<TextMeshPro>().text;
            GetComponent<TextMeshPro>().text = "Are you sure?Y / N";
            click = true;
        }
    }
    public string information()
    {
        return str;
    }
    public float cost() { return sum;}
    public void ExecuteAction()
    {
        if (conf1 != null)
        {
            conf1.otherClick = false;
        }
        if (conf2 != null)
        {
            conf2.otherClick = false;
        }
        ass.add(information(),cost());
        mon.set(-cost());
        GetComponent<TextMeshPro>().text = "Mazal tov";
        DataHolder.lastTask[DataHolder.taskIndex] = "you get " + information() + string.Format(" its cost {0}$", cost());
        DataHolder.taskIndex = (DataHolder.taskIndex + 1) % DataHolder.lastTask.Length;
        
    }
    private void CancelAction()
    {
        if(conf1!= null)
        {
            conf1.otherClick = false;
        }
        if (conf2 != null)
        {
            conf2.otherClick = false;
        }
        GetComponent<TextMeshPro>().text = origin_text;
    }

}