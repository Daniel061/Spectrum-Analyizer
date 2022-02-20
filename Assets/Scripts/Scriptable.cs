using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


 [CreateAssetMenu(menuName = "DataCollectionManager", fileName = "DataCollectionManager")]
public class Scriptable : ScriptableObject
{
    [Header("Variables")]
    [Tooltip("Must be a power of 2")]
    public int SampleSize;



    [Header("Data Collections")]
    public float[] Frequencies;
    public List<Scrollbar> ScrollBarList;
    public AudioClip audioClip;


    [Header("Tuning")]
    public float Gain;
}
