using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{
    [SerializeField] scoreUpdate scoreField;
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;
    private float score;
    float target_score = 100f;
    float loss_score = 50;
    void Start()
    {
        score = 0;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y > score)
        {
            score = transform.position.y;
            bool get_to_score_level1 = score > target_score && SceneManager.GetActiveScene().name == "level1";
            bool get_to_score_level2 = score > target_score && SceneManager.GetActiveScene().name == "level2";

            if (get_to_score_level1)
            {
                string nextLevel = "level2"; // the string you want to pass to the next scene
                SceneManager.LoadScene("next_level", LoadSceneMode.Single);
                PlayerPrefs.SetString("myString", nextLevel);
            }
            if (get_to_score_level2)
            {
                string nextLevel = "level3"; // the string you want to pass to the next scene
                SceneManager.LoadScene("next_level", LoadSceneMode.Single);
                PlayerPrefs.SetString("myString", nextLevel);
            }
        }
        scoreField.SetNumber(score);
        bool is_fall = loss_score < score - transform.position.y;
        if (is_fall)
        {
            string myString = SceneManager.GetActiveScene().name; // the string you want to pass to the next scene
            SceneManager.UnloadScene("gameMode");
            GameObject[] allObjects = FindObjectsOfType<GameObject>();
            foreach (GameObject obj in allObjects)
            {
                Debug.Log("Found GameObject: " + obj.name);

                if (obj.name.StartsWith("platform") || obj.name.StartsWith("ball") || obj.name.StartsWith("enemy")|| obj.name.StartsWith("Trampoline"))
                {
                    Destroy(obj);
                    // Do something with the found GameObject
                }
            }
            SceneManager.LoadScene("gameMode", LoadSceneMode.Additive);
            PlayerPrefs.SetString("myString", myString);
        }
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
    }

    public void SetScoreField(scoreUpdate newTextField)
    {
        this.scoreField = newTextField;
    }
}
