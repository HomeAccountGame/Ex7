using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class scoreUpdate : MonoBehaviour
{

    float score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0.0f;
        GetComponent<TextMeshPro>().text = score.ToString();

    }
    public void SetNumber(float newNumber)
    {
        this.score = newNumber;
           
        GetComponent<TextMeshPro>().text = Mathf.Round(score).ToString();
    }
}
