using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class UpdateMoney : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float bank;
    // Update is called once per frame
    void Update()
    {
        var stringList = DataHolder.StringList;
        bank = DataHolder.FloatValue;
        GetComponent<TextMeshPro>().text = bank.ToString();
    }
}
