using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioSourceControl : MonoBehaviour
{
    AudioSource audioSource;
    public Scriptable DataCollections;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        LoadClip();
        if(audioSource.clip != null) PlayCurrentClip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadClip()
    {
        audioSource.clip = DataCollections.audioClip;

    }

     void PlayCurrentClip()
    {
        audioSource.Play();
    }

    public void LoadAudioFromFile()
    {
        Debug.Log("Load Called");
        System.Diagnostics.Process p = new System.Diagnostics.Process();
        p.StartInfo = new System.Diagnostics.ProcessStartInfo("explorer.exe");
        p.Start();

    }
}
