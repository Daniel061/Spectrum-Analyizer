using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarsUpdate : MonoBehaviour
{
    ColorBlock ColorRoll;
    Color color;
    public Scriptable DataCollections;
    float LastFreqValue = 0;
    float LastFreqValueHolder = 0;

 
    void Update()
    {
        float locaLGain = DataCollections.Gain;
        if (DataCollections.UseLinearGain == false) locaLGain = 2;
        for (int i = DataCollections.ScrollBarList.Count-1; i > 0; i--)
        {
                    //messing with color
                    ColorRoll = DataCollections.ScrollBarList[i].colors;
                    color = DataCollections.ScrollBarList[i].colors.normalColor ;
                    //color.b  += i + .1f;
                    ColorRoll.normalColor = color;
                    DataCollections.ScrollBarList[i].colors = ColorRoll;
            if (DataCollections.UseSmoothing)
            {
                LastFreqValueHolder = DataCollections.Frequencies[DataCollections.ScrollBarList.Count - i];
                DataCollections.Frequencies[DataCollections.ScrollBarList.Count - i] = DataCollections.Frequencies[DataCollections.ScrollBarList.Count - i] + LastFreqValue / 2;
                LastFreqValue = LastFreqValueHolder;
            }

            DataCollections.ScrollBarList[i].size = DataCollections.Frequencies[DataCollections.ScrollBarList.Count-i] * (locaLGain * (DataCollections.ScrollBarList.Count - i )/ 2); // increase gain towards higher freqs
        }
    }

}
