using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BarsUpdate : MonoBehaviour
{
    public Scriptable DataCollections;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       for(int i = 0; i < DataCollections.ScrollBarList.Count; i++)
        {
            DataCollections.ScrollBarList[i].size = DataCollections.Frequencies[i] * (DataCollections.Gain * i / 2); // increase gain towards higher freqs
        }
    }
}
