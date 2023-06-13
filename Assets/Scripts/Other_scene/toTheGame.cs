using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toTheGame : MonoBehaviour
{
    // Start is called before the first frame update
    public string name;
    public void toTheMain()
    {
        //Update the data holder
        SceneManager.LoadScene(name);
    }
}
