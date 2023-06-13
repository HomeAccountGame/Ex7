using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterAmount : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string str;
    [SerializeField] GameObject input;
    [SerializeField] Confitmation conf;
    private float sum;
    public void OnMouseDown()
    {
        input.SetActive(!input.activeSelf);
    }
    public void end()
    {
        input.SetActive(!input.activeSelf);
        conf.str = str;
        conf.sum = sum;
        conf.ExecuteAction();
    }
    public void setSum(string val)
    {
        sum = float.Parse(val);
    }
}
