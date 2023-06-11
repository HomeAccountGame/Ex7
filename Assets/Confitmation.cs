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
    string origin_text;

    private bool click = false;
    void Update()
    {
        if (click)
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
        origin_text = GetComponent<TextMeshPro>().text;
        GetComponent<TextMeshPro>().text = "Are you sure?Y / N";
        click = true;
    }
    public string information()
    {
        return str;
    }
    public float cost() { return sum;}
    private void ExecuteAction()
    {
        mon.set(-cost());
        ass.add(information(),cost());
        GetComponent<TextMeshPro>().text = "Mazal tov";
    }
    private void CancelAction()
    {
        GetComponent<TextMeshPro>().text = origin_text;
    }

}