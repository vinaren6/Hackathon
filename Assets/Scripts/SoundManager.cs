using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instace { get; private set; }
    AudioSource audioData;
    public AudioClip firstAudio;
    public AudioClip secondAudio;
    bool flag = false;
    private void Awake()
    {
        if (Instace == null)
        {
            Instace = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.loop = true;
        audioData.PlayOneShot(firstAudio, 0.7F);
   
        //audioData.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
       
        int SceneInt = SceneManager.GetActiveScene().buildIndex;
        if (SceneInt == 1 && flag == false)
        {
            print("test");
            audioData.Stop();
            audioData.PlayOneShot(secondAudio, 0.7F);
            flag = true;
        }
       
    }
}
