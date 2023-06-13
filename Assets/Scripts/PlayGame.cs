using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] JumpScene nextScene;
    [SerializeField] string game_name;

    private void OnMouseDown()
    {
        button.SetActive(!button.activeSelf);
        DataHolder.sceneName = game_name;
        nextScene.SwitchScene(game_name);
    }
}
