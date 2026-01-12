using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
public class Shop : MonoBehaviour
{
    public int Coin;

    public int StrawberrySeed;

    public int WatermelonSeed;
     
    public int MangoSeed;

    public int CoconutSeed;

    public TextMeshProUGUI Coin_text;

    public TextMeshProUGUI StrawberrySeed_text;

    public TextMeshProUGUI WatermelonSeed_text;

    public TextMeshProUGUI MangoSeed_text;

    public TextMeshProUGUI CoconutSeed_text;

    public TextMeshProUGUI Strawberry_text;

    public TextMeshProUGUI Watermelon_text;

    public TextMeshProUGUI Mango_text;

    public TextMeshProUGUI Coconut_text;

    public int strawberry;

    public int watermelon;

    public int mango;

    public int coconut;
    public void Start()
    {
        Coin = 10;
        Coin_text.text = Coin.ToString();
    }

    public void BuyStrawberrySeed()
    {
        if(Coin >= 10)
        {
          Coin -= 10;
          Coin_text.text = Coin.ToString();

          StrawberrySeed += 1;
          StrawberrySeed_text.text = StrawberrySeed.ToString();

            if (Instructions.Instance.step == 1)
            {
                Instructions.Instance.step = 2;
            }
        }
        else
        {
            print("Not enough Coins");
        }
    }

    public void BuyWatermelonSeed()
    {
        if(Coin >= 20)
        {
            Coin -= 20;
            Coin_text.text = Coin.ToString();

            WatermelonSeed += 1;
            WatermelonSeed_text.text = WatermelonSeed.ToString();
        }
        else
        {
            print("Not enough Coins");
        }
    }

    public void BuyMangoSeed()
    {
        if (Coin >= 50)
        {
            Coin -= 50;
            Coin_text.text = Coin.ToString();

            MangoSeed += 1;
            MangoSeed_text.text = MangoSeed.ToString();
        }
        else
        {
            print("Not enough Coins");
        }
    }

    public void BuyCoconutSeed()
    {
        if (Coin >= 100)
        {
            Coin -= 100;
            Coin_text.text = Coin.ToString();

            CoconutSeed += 1;
            CoconutSeed_text.text = CoconutSeed.ToString();
        }
        else
        {
            print("Not enough Coins");
        }
    }

    public void SellStrawberry()
    {
        if (strawberry > 0)
        {
            Coin += 12;
            Coin_text.text = Coin.ToString();
            strawberry -= 1;
            Strawberry_text.text = strawberry.ToString();
            if (Instructions.Instance.step == 0)
            {
                Instructions.Instance.step = 1;
            }
        }
        else
        {
            print("Nothing to sell...");
        }
    }

    public void SellWatermelon()
    {
        if (watermelon > 0)
        {
            Coin += 25;
            Coin_text.text = Coin.ToString();
            watermelon -= 1;
            Watermelon_text.text = watermelon.ToString();
        }
        else
        {
            print("Nothing to sell...");
        }
    }

    public void SellMango()
    {
        if (mango > 0)
        {
            Coin += 60;
            Coin_text.text = Coin.ToString();
            mango -= 1;
            Mango_text.text = mango.ToString();
        }
        else
        {
            print("Nothing to sell...");
        }
    }

    public void SellCoconut()
    {
        if (coconut > 0)
        {
            Coin += 25;
            Coin_text.text = Coin.ToString();
            coconut -= 1;
            Coconut_text.text = coconut.ToString();
        }
        else
        {
            print("Nothing to sell...");
        }
    }
}
