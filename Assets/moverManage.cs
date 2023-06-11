using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverManage : MonoBehaviour
{
    [SerializeField] movers move;
    [SerializeField] JumpScene nextScene;
    [SerializeField] private List<Vector3> locations = new List<Vector3>();
    [SerializeField] GameObject otherObject;
    [SerializeField] private List<Vector3> index = new List<Vector3>();
    [SerializeField] private List<string> scene_list = new List<string>();
    [SerializeField] GameObject giftManage;
    [SerializeField] GameObject efctor;

    [SerializeField] giftPoll giftP;
    [SerializeField] task_manag task;
    [SerializeField] TaskPollNew taskP;
    [SerializeField] GameObject button;



    private int counter = 0;
    private int index_counter = 0;
    private int count_step = 0;
    private bool getTarget = false;
    // Update is called once per frame
    void start()
    {
    }
    public void nextTurn()
    {
        //update money like every quater by the asset,family,invesment,Transportation,work;
        move.moveTo(locations[counter % locations.Count]);
        getTarget = false;
        count_step = 2;

    }

    IEnumerator wait()
    {

        yield return moveing();

    }
    IEnumerator moveing()
    {
        move.moveTo(locations[counter % locations.Count]);
        yield return new WaitForSeconds(1f);
        counter++;
    }
    void Update()
    {
        if (Vector3.Distance(otherObject.transform.position, index[index_counter]) < 0.1f && !getTarget)
        {
            move.stop();
            getTarget = true;
            if (scene_list[index_counter] == "gift")
            {
                efctor.SetActive(!efctor.activeSelf);
                giftManage.SetActive(!giftManage.activeSelf);
                StartCoroutine(wait_screen());
                button.SetActive(!button.activeSelf);
            }
            else if (scene_list[index_counter] == "task")
            {
                task.open_close();
                taskP.GetRandomTask();
                
            }
            else
            {
                button.SetActive(!button.activeSelf);
                DataHolder.sceneName = scene_list[index_counter];
                nextScene.SwitchScene(scene_list[index_counter]);
            }
            index_counter += 1;
            index_counter = index_counter % index.Count;
        }
        if (Vector3.Distance(otherObject.transform.position, locations[counter % locations.Count]) < 0.1f && count_step > 0)
        {
            counter++;
            move.moveTo(locations[counter % locations.Count]);
            count_step -= 1;
        }
    }
    IEnumerator wait_screen()
    {
        giftP.GetRandomGift();
        yield return new WaitForSeconds(4.5f);
        giftManage.SetActive(!giftManage.activeSelf);
        efctor.SetActive(!efctor.activeSelf);

        button.SetActive(!button.activeSelf);
    }
}