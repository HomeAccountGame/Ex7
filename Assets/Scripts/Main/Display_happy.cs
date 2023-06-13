using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class Display_happy : MonoBehaviour
{
    private float happy;
    public Text text;
    void Update()
    {
        happy = DataHolder.happines;
        //GetComponent<TextMeshPro>().text = bank.ToString();
        text.text = "=) "+happy.ToString();
        //text.text = "hello";
    }
}