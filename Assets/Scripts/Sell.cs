using UnityEngine;

public class Sell : MonoBehaviour
{
    public Shop shop;
    public GameObject Ok;
    public void Start()
    {

    }

    public void SellStrawberry()
    {
        if (shop.strawberry > 0)
        {
            shop.Coin += 15;
            shop.Coin_text.text = shop.Coin.ToString();
            shop.strawberry -= 1;
            shop.Strawberry_text.text = shop.strawberry.ToString();
            if (Instructions.Instance.step == 4)
            {
                Instructions.Instance.step = 5;
                
            }
        }
        else
        {
            print("Nothing to sell...");
        }
    }

    public void SellWatermelon()
    {
        if (shop.watermelon > 0)
        {
            shop.Coin += 35;
            shop.Coin_text.text = shop.Coin.ToString();
            shop.watermelon -= 1;
            shop.Watermelon_text.text = shop.watermelon.ToString();
        }
        else
        {
            print("Nothing to sell...");
        }
    }

    public void SellMango()
    {
        if (shop.mango > 0)
        {
            shop.Coin += 70;
            shop.Coin_text.text = shop.Coin.ToString();
            shop.mango -= 1;
            shop.Mango_text.text = shop.mango.ToString();
        }
        else
        {
            print("Nothing to sell...");
        }
    }

    public void SellCoconut()
    {
        if (shop.coconut > 0)
        {
            shop.Coin += 130;
            shop.Coin_text.text = shop.Coin.ToString();
            shop.coconut -= 1;
            shop.Coconut_text.text = shop.coconut.ToString();
        }
        else
        {
            print("Nothing to sell...");
        }

    }

}
