using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableDataManager", fileName = "DataManager")]
public class ScriptableDataManager : ScriptableObject
{
    public int SampleSize = 1024;
    public float[] frequencies;
}