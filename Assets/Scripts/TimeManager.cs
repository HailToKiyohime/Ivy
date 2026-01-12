using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class TimeManager : MonoBehaviour
{
    public List<PlantObject> plantObjects = new List<PlantObject>();

    public static TimeManager Instance;

    private void Awake()
    {
        if (Instance == null) {

            Instance = this;
        }
    }

    public void RegisterPlant(PlantObject plantObject) {

        plantObjects.Add(plantObject);
    }

    public void UnregisterPlant(PlantObject plantObject)
    {
        plantObjects.Remove(plantObject);
    }

    public void Update()
    {
        if (plantObjects!=null)
        {
            foreach (PlantObject plantObject in plantObjects)
            {
                plantObject.CheckPlant(Time.deltaTime);
            }

            plantObjects.RemoveAll(x => x.HasMaxLevel());
        }

    }

}
