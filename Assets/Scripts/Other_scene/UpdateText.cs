using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class UpdateText : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public void setText(string str)
    {
        text.text = str;
    }
}
