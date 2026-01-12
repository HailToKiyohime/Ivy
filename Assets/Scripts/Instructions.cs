using UnityEngine;
using TMPro;
public class Instructions : MonoBehaviour
{
    // A public static reference to the single instance of the class
    public static Instructions Instance { get; private set; }


    public TextMeshProUGUI MainScreen;
    public bool tutorialON;
    public int step;
    public GameObject InstructionScreen;
    public GameObject Continue;
    public GameObject Ok;
    public GameObject StartGame;
    public GameObject Arrow;
    public Timer Timer;
    private void Awake()
    {
        // Check if an instance already exists
        if (Instance != null && Instance != this)
        {
            // If so, destroy this new object instance (the duplicate)
            Destroy(this.gameObject);
            return;
        }

        // If not, set the static reference to this instance
        Instance = this;
    }
    public void Update()
    {
        changeInstructions();
    }
    public void changeInstructions()
    {
        if (step == 1)
        {
            MainScreen.text = "Go to the seed shop to buy the strawberry seed";
        }
        else if (step == 2)
        {
            MainScreen.text = "Head to your garden, press 1 to plant the seed";
        }
        else if (step == 3)
        {
            MainScreen.text = "Harvest the fruit by touching it ";
        }
        else if (step == 4)
        {
            MainScreen.text = "Go to the sell shop to sell your fruit";
        }
        else if (step == 5)
        {
            Ok.SetActive(true);
            MainScreen.text = "Go back to the seed shop, buy seed(s), plant it, and sell it to play the game.";

        }
        else if (step == 6)
        {
            MainScreen.text = "Goal: Obtain 200 coins before the timer ends. Button for plants: 1 = strawberry, 2 = Watermelon, 3 = Mango, 4 = Coconut.";
        }


    }

    public void OnContinueClick()
    {
        Instructions.Instance.step = 1;
        Continue.SetActive(false);
    }

    public void OnStartGameClick()
    {
        Instructions.Instance.step = 7;
        InstructionScreen.SetActive(false);
        StartGame.SetActive(false);
        Arrow.SetActive(false);
        Timer.timerIsRunning = true;

    }

    public void OnOkClick()
    {
        Instructions.Instance.step = 6;
        Ok.SetActive(false);
        StartGame.SetActive(true);
        
        
    }

}
    