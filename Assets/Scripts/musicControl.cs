using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicControl : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Audio;
    public AudioClip gift;
    public AudioClip jump;
    public AudioClip bank;


    public static musicControl insMusic;
    void Awake()
    {
        if(insMusic!=null && insMusic != this)
        {
            Destroy(this.gameObject);
            return;
        }
        insMusic = this;
        //DontDestroyOnLoad(this);
    }

}
