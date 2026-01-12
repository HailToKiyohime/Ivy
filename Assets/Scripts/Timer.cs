using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    // Assign your UI TextMeshPro object in the Inspector
    public TextMeshProUGUI timerText;
    public GameObject GameOverScreen;      
    public float countdownTime = 180f; 
    public bool timerIsRunning = false;
    public GameObject TutorialScreen;

    void Start()
    {
     
    }

    void Update()
    {
        if (timerIsRunning)
        {
            countdownTime -= Time.deltaTime;
            DisplayTime(countdownTime);
        }

        void DisplayTime(float timeToDisplay)
        {
            // Check if time has run out for countdown
            if (timeToDisplay < 0)
            {
                timeToDisplay = 0;
                timerIsRunning = false; // Stop the timer when it hits zero
                Debug.Log("Time is up!"); // Trigger game over condition here
                GameOverScreen.SetActive(true);
            }

            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);

            // Use string.Format to ensure leading zeros (e.g., 05:02)
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}



