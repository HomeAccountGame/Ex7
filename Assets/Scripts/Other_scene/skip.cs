using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skip : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject otherGameObject;
    public void skipT()
    {
        otherGameObject.SetActive(!otherGameObject.activeSelf);
    }
}
