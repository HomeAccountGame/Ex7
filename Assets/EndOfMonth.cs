using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfMonth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float up_preccnt_ass;
    [SerializeField] float up_preccnt_bank;
    [SerializeField] float Interest_minus;
    

    public void end_of_month()
    {
        Dictionary<string, float> asset = DataHolder.StringList;
        Update_happiness(asset);
        Update_money(asset);
        Updat_knowledge(asset);
        Update_invesment(asset);
    }
    private void Update_money(Dictionary<string, float> asset)
    {
        float money = DataHolder.FloatValue;
        if (asset.ContainsKey("Doctor"))
        {
            money += asset["Doctor"];
        }
        else if (asset.ContainsKey("Teacher"))
        {
            money += asset["Teacher"];
        }
        else if (asset.ContainsKey("Lower"))
        {
            money += asset["Lower"];
        }
        if (asset.ContainsKey("arnona"))
        {
            money += asset["arnona"];
        }
        if (asset.ContainsKey("salary"))
        {
            money += asset["salary"];
        }
        if (asset.ContainsKey("bus"))
        {
            Debug.Log("bus");
            money -= asset["bus"];
        }
        if (asset.ContainsKey("car"))
        {
            money += asset["car"];
        }
        if (asset.ContainsKey("food"))
        {
            money -= asset["food"];
        }
        //all the assets;
        //down the money for food
        if (money<0)
        {
            money = money + money * Interest_minus;
        }
    }

    private void Updat_knowledge(Dictionary<string, float> asset)
    {
        float knowledge = DataHolder.knowledge;
        knowledge += 0.1f;
        if(asset.ContainsKey("Student"))
        {
            knowledge += asset["Student"];
        }
        if (asset.ContainsKey("IndepentJob"))
        {
            knowledge += asset["IndepentJob"];
        }
        if (asset.ContainsKey("gift"))
        {
            knowledge += asset["gift"];
        }
        if (asset.ContainsKey("task"))
        {
            knowledge += asset["task"];
        }
        else if (asset.ContainsKey("Teacher"))
        {
            knowledge += 0.3f;
        }
        if (knowledge > 5f) knowledge = 5f;
        if (knowledge < 0f) knowledge = 0f;
        DataHolder.knowledge=knowledge;


    }
    private void Update_happiness(Dictionary<string, float> asset)
    {
        float happines = DataHolder.happines;
        happines += 0.1f;
        //base on the disiction you made
        if (asset.ContainsKey("job"))
        {
            happines += 0.1f;
        }
        if (asset.ContainsKey("disiction"))
        {
            happines += asset["disiction"];
        }
        if (asset.ContainsKey("wife"))
        {
            happines += asset["wife"];
        }
        if (asset.ContainsKey("living"))
        {
            happines += asset["living"];
        }
        if (asset.ContainsKey("family"))
        {
            happines += asset["family"];
        }
        if (asset.ContainsKey("car_happy"))
        {
            happines += asset["car_happy"];
        }
        if(asset.ContainsKey("family") && asset.ContainsKey("bus"))
        {
            happines -= 0.3f;
        }
        if (asset.ContainsKey("doctor"))
        {
            happines -= 0.3f;
        }
        else if (asset.ContainsKey("Teacher") || asset.ContainsKey("Lower"))
        {
            happines += 0.1f;
        }
        if (happines > 5f) happines = 5f;
        if (happines < 0f) happines = 0f;
        DataHolder.happines = happines;
    }
    private void Update_invesment(Dictionary<string, float> asset)
    {
        //Dictionary<string, float>;
        if (asset.ContainsKey("real ass"))
        {
            Debug.Log(asset["real ass"]);
            asset["real ass"] = asset["real ass"] + asset["real ass"] * up_preccnt_ass;
        }
        if (asset.ContainsKey("bank"))
        {
            asset["bank"] = asset["bank"] + asset["bank"] * up_preccnt_bank;
        }
    }
    //return asset;
}
