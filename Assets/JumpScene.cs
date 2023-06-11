using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScene : MonoBehaviour
{
    [SerializeField] float start_money = 100000f;
    [SerializeField] float start_happy = 0f;
    [SerializeField] float start_know = 0f;
    [SerializeField] GameObject button;

    private bool retunToMain = false;
    void Start()
    {
        DataHolder.StringList = new Dictionary<string, float>();
        DataHolder.FloatValue = start_money;
        DataHolder.knowledge = start_know;
        DataHolder.happines = start_happy; 
    }
    void Update()
    {
        if(DataHolder.sceneName=="Main"&& retunToMain)
        {
            button.SetActive(!button.activeSelf);
            retunToMain = false;
        }
    }
    // Start is called before the first frame update
    private string originalScene = "Main";

    public void SwitchScene(string sceneName)
    {
        retunToMain = true;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
        //originalScene = SceneManager.GetActiveScene().name;
        //SceneManager.LoadScene(sceneName);
    }

    public void ReturnToOriginalScene()
    {
        //SceneManager.LoadScene(originalScene);
    }
}
