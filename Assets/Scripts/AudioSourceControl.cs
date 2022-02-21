using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioSourceControl : MonoBehaviour
{
    AudioSource audioSource;
    public Scriptable DataCollections;
    FFTWindow window;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        LoadClip();
        if(audioSource.clip != null) PlayCurrentClip();
    }

    // Update is called once per frame
    void Update()
    {
        DataCollections.Frequencies = new float[DataCollections.SampleSize];
        audioSource.GetSpectrumData(DataCollections.Frequencies, 0, window);
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
