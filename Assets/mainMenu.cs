using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject otherGameObject1;
    [SerializeField] GameObject otherGameObject2;
    [SerializeField] GameObject otherGameObject3;
    [SerializeField] GameObject menu1;
    [SerializeField] GameObject menu2;
    [SerializeField] GameObject menu3;
    [SerializeField] GameObject art;


    private void OnMouseDown()
    {
        Debug.Log("click");
        otherGameObject1.SetActive(true); 
        otherGameObject2.SetActive(true);
        otherGameObject3.SetActive(true);
        art.SetActive(true);
        menu1.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(false);
    }
}
