using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;

    private Vector2 moveDirection;

    public GameObject ShopWindow;

    public GameObject SellWindow;

    public GameObject TutorialScreen;

    public Shop shop;

    public GameObject strawberry;

    public GameObject watermelon;

    public GameObject mango;

    public GameObject coconut;

    public GameObject Arrow;

    public GameObject InstructionScreen;

    public GameObject Continue;

    public Timer Timer;

   

    void Update()
    {
        ProcessInputs();
        if (Input.GetKeyDown(KeyCode.Alpha1) && shop.StrawberrySeed > 0)
        {
            Instantiate(strawberry,transform.position, Quaternion.identity);
            shop.StrawberrySeed -= 1;
            shop.StrawberrySeed_text.text = shop.StrawberrySeed.ToString();
            if (Instructions.Instance.step == 2)
            {
                Instructions.Instance.step = 3;
            }

        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && shop.WatermelonSeed > 0)
        {
            Instantiate(watermelon, transform.position, Quaternion.identity);
            shop.WatermelonSeed -= 1;
            shop.WatermelonSeed_text.text = shop.WatermelonSeed.ToString();
           

        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && shop.MangoSeed > 0)
        {
            Instantiate(mango, transform.position, Quaternion.identity);
            shop.MangoSeed -= 1;
            shop.MangoSeed_text.text = shop.MangoSeed.ToString();
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && shop.CoconutSeed > 0)
        {
            Instantiate(coconut, transform.position, Quaternion.identity);
            shop.CoconutSeed -= 1;
            shop.CoconutSeed_text.text = shop.CoconutSeed.ToString();
            
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

    }

    void Move()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            ShopWindow.SetActive(true);
        }
        if (collision.gameObject.tag == "Sell")
        {
            SellWindow.SetActive(true);
        }

        if (collision.gameObject.tag == "Strawberry")
        {
            if (collision.gameObject.GetComponent<PlantObject>().HasMaxLevel())
            {
                Debug.Log(" working");
                shop.strawberry += 1;
                shop.Strawberry_text.text = shop.strawberry.ToString();
                Destroy(collision.gameObject);
                if (Instructions.Instance.step == 3)
                {
                    Instructions.Instance.step = 4;
                }

            }
            else
            {
                Debug.Log("not working");
            }
        }


        if (collision.gameObject.tag == "Watermelon")
        {
            if (collision.gameObject.GetComponent<PlantObject>().HasMaxLevel())
            {
                shop.watermelon += 1;
                shop.Watermelon_text.text = shop.watermelon.ToString();
                Destroy(collision.gameObject);

            }
        }

        if (collision.gameObject.tag == "Mango")
        {
            if (collision.gameObject.GetComponent<PlantObject>().HasMaxLevel())
            {
                shop.mango += 1;
                shop.Mango_text.text = shop.mango.ToString();
                Destroy(collision.gameObject);

            }
        }

        if (collision.gameObject.tag == "Coconut")
        {
            if (collision.gameObject.GetComponent<PlantObject>().HasMaxLevel())
            {
                shop.coconut += 1;
                shop.Coconut_text.text = shop.coconut.ToString();
                Destroy(collision.gameObject);

            }
        }

    }
    public void OnBackToGameClick()
    {
        ShopWindow.SetActive(false);
        SellWindow.SetActive(false);
    }

    public void OnSkipTutorialClick()
    {
        Arrow.SetActive(false);
        GetComponent<PointToShop>().enabled = false;
        TutorialScreen.SetActive(false);
        InstructionScreen.SetActive(false);
        Continue.SetActive(false);
        Timer.timerIsRunning = true;

    }

    public void OnStartTutorialClick()
    {
        TutorialScreen.SetActive(false);
    }

}
