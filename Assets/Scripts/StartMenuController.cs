using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public GameObject InstructionsScreen;
    
    public void OnStartClick()
    {
        SceneManager.LoadScene("BloomGarden");
    }


    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();

    }

    public void OnInstructionsClick()
    {
        InstructionsScreen.SetActive(true);
    }

    public void OnGoBackClick()
    {
        InstructionsScreen.SetActive(false);
    }
}
