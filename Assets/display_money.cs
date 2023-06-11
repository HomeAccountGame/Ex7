using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class display_money : MonoBehaviour
{
    private float bank;
    public Text text;
    void Update()
    {
        bank = DataHolder.FloatValue;
        //GetComponent<TextMeshPro>().text = bank.ToString();
        text.text = bank.ToString();
        //text.text = "hello";
    }
}
