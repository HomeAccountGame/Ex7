using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class asset_show : MonoBehaviour
{
    // Start is called before the first frame update

    public Confitmation conf;
    public void show_asset()
    {
        Dictionary<string, float> asset = DataHolder.StringList;
        if (asset.ContainsKey("house"))
        {
            GetComponent<TextMeshPro>().text = "house  " + asset["house"].ToString();
            conf.str = "";
            conf.sum = -asset["house"];
            DataHolder.StringList.Remove("house");

        }
        if (asset.ContainsKey("apartment"))
        {
            GetComponent<TextMeshPro>().text = "apartment  " + asset["apartment"].ToString();
            conf.str = "";
            conf.sum = -asset["apartment"];
            DataHolder.StringList.Remove("apartment");

        }
        if (asset.ContainsKey("office"))
        {
            GetComponent<TextMeshPro>().text = "office  " + asset["office"].ToString();
            conf.str = "";
            conf.sum = -asset["office"];
            DataHolder.StringList.Remove("office");
        }
        if (asset.ContainsKey("real ass"))
        {
            GetComponent<TextMeshPro>().text = "real ass  " + asset["real ass"].ToString();
            conf.str = "";
            conf.sum = -asset["real ass"];
            DataHolder.StringList.Remove("real ass");

        }

    }
}
