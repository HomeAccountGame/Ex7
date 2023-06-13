using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class showFinal : MonoBehaviour
{
    private float bank;
    public Text text;
    void Start()
    {
        bank = DataHolder.FloatValue;
        //GetComponent<TextMeshPro>().text = bank.ToString();
        text.text += bank.ToString();
        //text.text = "hello";
    }
}