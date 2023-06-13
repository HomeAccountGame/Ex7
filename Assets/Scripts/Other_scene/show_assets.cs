using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class show_assets : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, float> asset = DataHolder.StringList;
        foreach (KeyValuePair<string, float> assets in asset)
        {
            string assetName = assets.Key;
            float assetValue = assets.Value;
            text.text += assetName+"="+ assetValue.ToString();
        }


    }
}
