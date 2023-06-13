using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_all : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            Debug.Log("Found GameObject: " + obj.name);

            if (obj.name.StartsWith("platform") || obj.name.StartsWith("ball") || obj.name.StartsWith("enemy") ||obj.name.StartsWith("Trampoline"))
            {
                Destroy(obj);
                // Do something with the found GameObject
            }
        }
    }
}
