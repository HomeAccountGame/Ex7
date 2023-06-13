using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Money mon;
    [SerializeField] Asset ass;

    public void OnMouseDown()
    {
        Debug.Log(DataHolder.sceneName);
        if (ass && mon)
        {
            Dictionary<string, float> temp = ass.getAll();
            foreach (var kvp in temp)
            {
                string key = kvp.Key;
                float value = kvp.Value;

                if (!DataHolder.StringList.ContainsKey(key))
                {
                    DataHolder.StringList.Add(key, value);
                }
            }

            DataHolder.FloatValue = mon.get();
        }
        string savedSceneName = DataHolder.sceneName;
        DataHolder.sceneName = "Main";
        //SceneManager.LoadScene("NextSceneName");
        SceneManager.UnloadScene(savedSceneName);
    }
    
}
