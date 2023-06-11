using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class Money : MonoBehaviour
{
    // Start is called before the first frame update
    private float bank = DataHolder.FloatValue;
    void Start()
    {
        GetComponent<TextMeshPro>().text = bank.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //display on the screen
    }
    public void set(float sum)
    {
        bank += sum;
        GetComponent<TextMeshPro>().text = bank.ToString();

    }
    public float get() { return bank;}
}
