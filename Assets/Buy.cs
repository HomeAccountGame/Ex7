using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject otherGameObject;
    [SerializeField] GameObject menu1;
    [SerializeField] Confitmation conf;
    [SerializeField] Money mon;
    [SerializeField] Asset ass;
    private float cost;
    private string info;
    // Update is called once per frame
    private void OnMouseDown()
    {
        info = conf.information();
        cost = conf.cost();
        mon.set(-cost);
        //ass.add(info);
        otherGameObject.SetActive(!otherGameObject.activeSelf);
        menu1.SetActive(!menu1.activeSelf);
    }
}
