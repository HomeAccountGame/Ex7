using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class Show_happy : MonoBehaviour
{
    // Start is called before the first frame update
    private float happy;
    public Text text;
    void Start()
    {
        happy = DataHolder.happines;
        //GetComponent<TextMeshPro>().text = bank.ToString();
        text.text += happy.ToString();
        //text.text = "hello";
    }
}
