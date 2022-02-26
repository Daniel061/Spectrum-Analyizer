using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioSourceControl : MonoBehaviour
{
    AudioSource audioSource;
    public Scriptable DataCollections;
    //https://docs.unity3d.com/530/Documentation/ScriptReference/UI.Button-onClick.html
    public Button loadFileButton;
    public Button exitApplicationButton;
    public Toggle useSmoothingToggle;
   // public delegate void ChangeUseSmoothing();
    FFTWindow window;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        LoadClip();
        if (audioSource.clip != null) PlayCurrentClip();

        Button btn = loadFileButton.GetComponent<Button>();
        btn.onClick.AddListener(LoadAudioFromFile);
        Button btnExit = exitApplicationButton.GetComponent<Button>();
        btnExit.onClick.AddListener(() => ExitApplication());

        Toggle useListner = useSmoothingToggle.GetComponent<Toggle>();
        useListner.runInEditMode = true;
        //useListner.OnPointerClick += ChangeUseSmoothing;
    }


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

    void LoadAudioFromFile()
    {
        Debug.Log("Load Called");
        System.Diagnostics.Process p = new System.Diagnostics.Process();
        p.StartInfo = new System.Diagnostics.ProcessStartInfo("explorer.exe");
        p.Start();

    }

    void ExitApplication()
    {
        Debug.Log("Quit Called");
        Application.Quit();
    }

    void ChangeUseSmoothing()
    {
        if(DataCollections.UseSmoothing) DataCollections.UseSmoothing = false; else DataCollections.UseSmoothing = true;    
    }
}
