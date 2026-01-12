using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject PlayAgain;
    public GameObject Quit;
    public GameObject GameOverScreen;
    public GameObject TutorialScreen;
    public void OnPlayAgainClick()
    {
        GameOverScreen.SetActive(false);
        TutorialScreen.SetActive(true);
    }

    public void OnQuitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();

    }
}
    
    

