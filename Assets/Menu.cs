using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject otherGameObject;
    [SerializeField] GameObject menu1;
    [SerializeField] GameObject menu2;
    [SerializeField] GameObject menu3;
    [SerializeField] GameObject art;




    private void OnMouseDown()
    {
        otherGameObject.SetActive(!otherGameObject.activeSelf);
        menu1.SetActive(!menu1.activeSelf);
        menu2.SetActive(!menu2.activeSelf);
        menu3.SetActive(!menu3.activeSelf);
        art.SetActive(!art.activeSelf);
    }
}
