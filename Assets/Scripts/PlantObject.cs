using UnityEngine;
using UnityEngine.Rendering;
using System;

public class PlantObject : MonoBehaviour
{
    [SerializeField] private Plant plant;

    private int currentStage;

    private float currentTime;

    private GameObject currentPlant;

    private void Start()
    {
        TimeManager.Instance.RegisterPlant(this);

        // Instantiate the initial stage (stage 0)
        currentStage = 0;
        var initialPrefab = plant.GetPlantByStage(currentStage);
        if (initialPrefab != null)
        {
            currentPlant = Instantiate(initialPrefab, transform);
        }
        else
        {
            Debug.LogError($"[PlantObject] No prefab found for initial stage (0) in plant {plant?.name}");
        }
    }
    public void CheckPlant(float deltaTime)
    {
        currentTime += deltaTime;
        if (currentTime >= plant.CropTime && currentStage < plant.MaxStage - 1) { 

            currentStage++;
            currentTime = 0;
            Destroy(currentPlant);
            var nextStagePrefab = plant.GetPlantByStage(currentStage);
            if (nextStagePrefab == null)
            {
                Debug.LogError($"[PlantObject] Missing prefab for stage {currentStage} in plant {plant?.name}");
                return;
            }

            currentPlant = Instantiate(nextStagePrefab, transform);
            Debug.Log(plant.CropReward * currentStage);
            if (currentStage == plant.MaxStage)
            {
                TimeManager.Instance.UnregisterPlant(this);
            }
        
        }
    }

    public bool HasMaxLevel()
    {
        Debug.Log("currentStage:" + currentStage + "plant.MaxStage" + plant.MaxStage);
        return currentStage == plant.MaxStage-1;
    }
}
