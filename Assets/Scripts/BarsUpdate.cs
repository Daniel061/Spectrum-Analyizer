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
        float locaLGain = DataCollections.Gain;
        if (DataCollections.UseLinearGain == false) locaLGain = 2;
        for (int i = DataCollections.ScrollBarList.Count-1; i > 0; i--)
        {
            //Debug.Log(i);
            DataCollections.ScrollBarList[i].size = DataCollections.Frequencies[DataCollections.ScrollBarList.Count-i] * (locaLGain * (DataCollections.ScrollBarList.Count - i )/ 2); // increase gain towards higher freqs
        }
    }
}
