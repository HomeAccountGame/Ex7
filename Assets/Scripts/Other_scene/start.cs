using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    [SerializeField]toTheGame tog;
    void Start()
    {
        tog.toTheMain();
    }
}
