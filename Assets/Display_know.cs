using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class Display_know : MonoBehaviour
{
    private float know;
    public Text text;
    void Update()
    {
        know = DataHolder.knowledge;
        //GetComponent<TextMeshPro>().text = bank.ToString();
        text.text = know.ToString();
        //text.text = "hello";
    }
}