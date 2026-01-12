using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

[CreateAssetMenu(fileName = "Plant", menuName = "Scriptable Objects/Plant")]
public class Plant : ScriptableObject
{
    public string plantName;
    public List<GameObject> plantPrefabs;
    public int MaxStage { get { return plantPrefabs.Count; } }

    public float CropTime;

    public int CropReward;




    public GameObject GetPlantByStage(int stage)
    {
        if (stage >= MaxStage)
        {
            return null;
        }
        return plantPrefabs[stage];

    }
}
