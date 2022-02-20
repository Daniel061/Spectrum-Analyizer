using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateBars : MonoBehaviour
{
    public Scrollbar scrollBar;
    public Scriptable DataCollections;
    public Canvas canvas;
    Scrollbar newBar;
    Vector3 barPosition = Vector3.zero;
    Quaternion rotation;
   
    void Start()
    {
        DataCollections.ScrollBarList.Clear();
        //check SampleSize for power of two
        if (IsPowerOfTwo(DataCollections.SampleSize)){

            if (canvas != null) canvas.transform.position = barPosition;
            barPosition = canvas.transform.position;
            barPosition.x = 1 - DataCollections.SampleSize/2;

            for (int i = 1; i < DataCollections.SampleSize / 2; i++)
            {
                barPosition.x = (i+(-1 * DataCollections.SampleSize / 4)) * 5;
                barPosition.y = 52;
                barPosition.z = 0;
                // Debug.Log("New bar created at " + barPosition);
                scrollBar.transform.position = barPosition;
                newBar = Instantiate(scrollBar);
                //newBar.SetActive(true);
                newBar.transform.SetParent(canvas.transform);
                newBar.transform.SetPositionAndRotation(barPosition, rotation);
                newBar.name = "ScrollBar (" + i + ")";
                DataCollections.ScrollBarList.Add(newBar);

            }

        }
    }

    void Update()
    {
        
    }

    bool IsPowerOfTwo(int numberToTest)
    {
        if (!((numberToTest != 0) && ((numberToTest & (numberToTest - 1))) == 0))
        {
            Debug.Log("Sample Size Is Not Power of 2");
            return false;
        }

        return true;
    }
}
