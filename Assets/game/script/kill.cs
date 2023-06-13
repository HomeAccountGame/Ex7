using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            string myString = SceneManager.GetActiveScene().name; // the string you want to pass to the next scene
            
            SceneManager.UnloadScene("gameMode");
            GameObject[] allObjects = FindObjectsOfType<GameObject>();
            foreach (GameObject obj in allObjects)
            {
                Debug.Log("Found GameObject: " + obj.name);

                if (obj.name.StartsWith("platform") || obj.name.StartsWith("ball") || obj.name.StartsWith("enemy") || obj.name.StartsWith("Trampoline"))
                {
                    Destroy(obj);
                    // Do something with the found GameObject
                }
            }
            SceneManager.LoadScene("gameMode", LoadSceneMode.Additive);
            PlayerPrefs.SetString("myString", myString);
        }
    }
}
