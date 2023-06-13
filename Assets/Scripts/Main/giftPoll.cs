using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class giftPoll : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] GameObject thisGameObject;
    private Dictionary<string, float> gifts = new Dictionary<string, float>();
    private string text = "You got gift!!";

    public Text textshow;

    void Awake()
    {
        InitializeGifts();
        ShuffleGifts();
    }
    void InitializeGifts()
    {
        gifts.Add("Get a promotion at work", 5000f);
        gifts.Add("Receive a sports car as a gift", 10000f);
        gifts.Add("Inherit a luxurious mansion", 8000f);
        gifts.Add("Invest in the stock market and earn a fortune", 6000f);
        gifts.Add("Experience an eco-friendly city", 3000f);
        gifts.Add("Plan a family vacation to an exotic location", 4000f);
        gifts.Add("Start a successful business", 9000f);
        gifts.Add("Win a lottery jackpot", 10000f);
        gifts.Add("Buy a beachfront property", 7000f);
        gifts.Add("Discover a hidden treasure", 5000f);
        gifts.Add("Get a scholarship for further studies", 2000f);
        gifts.Add("if you drive with bus, get bonus!", 1000f);
        gifts.Add("Donate to a charitable cause", 3000f);
        gifts.Add("Invent a groundbreaking technology", 8000f);
        gifts.Add("Receive a lifetime supply of free meals", 4000f);
        gifts.Add("Become a famous actor/actress", 7000f);
        gifts.Add("Win a prestigious award", 5000f);
        gifts.Add("Find a rare and valuable artifact", 6000f);
        gifts.Add("Build an eco-friendly skyscraper", 9000f);
        gifts.Add("Start a successful organic farm", 3000f);
    }

    void ShuffleGifts()
    {
        List<KeyValuePair<string, float>> giftList = new List<KeyValuePair<string, float>>(gifts);

        // Use Fisher-Yates shuffle algorithm to randomize the order of gifts
        System.Random random = new System.Random();
        int n = giftList.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            KeyValuePair<string, float> temp = giftList[k];
            giftList[k] = giftList[n];
            giftList[n] = temp;
        }

        gifts = new Dictionary<string, float>(giftList);
    }
    void Update()
    {
        textshow.text = text;
    }
    public void GetRandomGift()
    {
        text = "You got gift!!";
        int randomIndex = UnityEngine.Random.Range(0, gifts.Count);
        int currentIndex = 0;
        foreach (var kvp in gifts)
        {
            if (currentIndex == randomIndex)
            {
                if(kvp.Key.StartsWith("if"))
                {
                    if (!DataHolder.StringList.ContainsKey("bus")) { return; }
                }
                text += "\n"+kvp.Key;
                text += "\nYou got- " + kvp.Value;
                DataHolder.FloatValue += kvp.Value;
                return;
            }
            currentIndex++;
        }
    }
}
