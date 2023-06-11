using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asset : MonoBehaviour
{
    private float arnona = -200f;
    // Start is called before the first frame update
    private Dictionary<string, float> ass = new Dictionary<string, float>();
    void Start()
    {
        //get the asset from the other scene
    }

    // Update is called once per frame
    public void add(string asset, float value)
    {
        ass[asset] = value;
        if(asset == "house")
        {
            ass["arnona"] = arnona;
            ass["real ass"] = value;    
        }
    }
    public float get(string key)
    {
        if (ass.ContainsKey(key))
        {
            return ass[key];
        }
        else
        {
            // Handle the case when the key is not found
            return -1f; // Default value
        }
    }
    public bool contain(string key)
    {
        return ass.ContainsKey(key);
    }
    public Dictionary<string, float> getAll() { return ass; }
}
