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
    [SerializeField] GameObject button2;
    [SerializeField] clothing cloth;

    private bool retunToMain = false;
    void Start()
    {
        DataHolder.StringList = new Dictionary<string, float>();
        DataHolder.FloatValue = start_money;
        DataHolder.knowledge = start_know;
        DataHolder.happines = start_happy;
        DataHolder.lastTask = new string[6];
        DataHolder.taskIndex = 0;
        cloth.upload_clothing();
    }
    void Update()
    {
        if(DataHolder.sceneName=="Main"&& retunToMain)
        {
            button.SetActive(!button.activeSelf);
            button2.SetActive(!button2.activeSelf);

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
