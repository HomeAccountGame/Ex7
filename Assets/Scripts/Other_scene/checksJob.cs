using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checksJob : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] BackToMain back;
    [SerializeField] Asset ass;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ass.contain("Doctor") || ass.contain("Lower") || ass.contain("Teacher"))
        {
            back.OnMouseDown();
        }
    }
}
