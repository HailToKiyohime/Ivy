using UnityEngine;

public class YouWin : MonoBehaviour
{
    public GameObject YouWinScreen;
    public Shop shop;
    public GameObject TutorialScreen;   

    // Update is called once per frame
    void Update()
    {
        if (shop.Coin >= 200)
        {
            YouWinScreen.SetActive(true);
        }
    }

    public void OnReplayClick()
    {
        YouWinScreen.SetActive(false);
        TutorialScreen.SetActive(true);
    }
}
