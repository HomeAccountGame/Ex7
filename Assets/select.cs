using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string[] list = {"skin","hair","beard","cap","chain","shirt","pants","shoes","prop"};
    [SerializeField] GameObject[] skin;
    [SerializeField] GameObject[] hair;
    [SerializeField] GameObject[] beard;
    [SerializeField] GameObject[] cap;
    [SerializeField] GameObject[] chain;
    [SerializeField] GameObject[] shirt;
    [SerializeField] GameObject[] pants;
    [SerializeField] GameObject[] shoes;
    [SerializeField] GameObject[] prop;



    public Texture[] skin_textures;

    public Texture[] beard_textures;

    public Texture[] hair_a_textures;
    public Texture[] hair_b_textures;
    public Texture[] hair_c_textures;
    public Texture[] hair_d_textures;
    public Texture[] hair_e_textures;

    public Texture[] cap_textures;
    public Texture[] cap2_textures;
    public Texture[] cap3_textures;
    public Texture[] chain1_textures;
    public Texture[] chain2_textures;
    public Texture[] chain3_textures;

    public Texture[] banker_suit_texture;

    public Texture cock_suit_texture;


    public Texture farmer_suit_texture;


    public Texture fireman_suit_texture;


    public Texture mechanic_suit_texture;


    public Texture nurse_suit_texture;

    public Texture police_suit_texture;


    public Texture roober_suit_texture;


    public Texture security_guard_suit_texture;


    public Texture seller_suit_texture;

    public Texture worker_suit_texture;


    public Texture[] glasses_texture;
    public Texture[] jacket_textures;
    public Texture[] pullover_textures;
    public Texture[] scarf_textures;
    public Texture[] shirt_textures;

    public Texture[] shoes1_textures;
    public Texture[] shoes2_textures;
    public Texture[] shoes3_textures;

    public Texture[] shortpants_textures;
    public Texture[] t_shirt_textures;
    public Texture[] tank_top_textures;
    public Texture[] trousers_textures;

    public GameObject[][] gameObjectsArray;
    void Awake()
    {
        // Initialize the array with a specific size
        gameObjectsArray = new GameObject[9][];
        gameObjectsArray[0] = skin;
        gameObjectsArray[1] = hair;
        gameObjectsArray[2] = beard;
        gameObjectsArray[3] = cap;
        gameObjectsArray[4] = chain;
        gameObjectsArray[5] = shirt;
        gameObjectsArray[6] = pants;
        gameObjectsArray[7] = shoes;
        gameObjectsArray[8] = prop;
    }

    int[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    public GameObject skin_head;
    public GameObject skin_body;

    int skin_color = 0;
    //int hairColor = UnityEngine.Random.Range(0, 4);
    int val = 0;
    //int male_female = UnityEngine.Random.Range(0, 2);
    bool hat;
    public void handleChange(int value)
    {
        val = value;
    }
    public void change()
    {
        //skin_head.GetComponent<Renderer>().materials[0].mainTexture = skin_textures[skin_color];
        //skin_body.GetComponent<Renderer>().materials[0].mainTexture = skin_textures[skin_color];
        //hair_a.SetActive(false);
        hair[array[val]].SetActive(true);
        hair[array[val]].GetComponent<Renderer>().materials[0].mainTexture = hair_a_textures[array[val]];
     
    }
    public void left()
    {
        array[val]--;
        array[val]= array[val]% gameObjectsArray[array[val]].Length;
        change();
    }
    public void right()
    {
        array[val]++;
        change();
    }
}
