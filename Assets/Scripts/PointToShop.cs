using UnityEngine;

public class PointToShop : MonoBehaviour
{
    public Transform seedShop;
    public Transform sellHouse;
    public Transform MyGarden;
    public GameObject Arrow;
    public LineRenderer line;
    public Instructions instructions;
    public int goToLocation = 0;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction;
        if (instructions.step!=7) {
            if (goToLocation == 0) {

                Arrow.gameObject.SetActive(true);
                direction = seedShop.position - line.transform.position;
            }
            else if (goToLocation == 1)
            {
                Arrow.gameObject.SetActive(true);
                direction = sellHouse.position - line.transform.position;
            }
            else
            {
                Arrow.gameObject.SetActive(true);
                direction = MyGarden.position - line.transform.position;

                Vector3 position1 = gameObject.GetComponentInParent<Transform>().position;
                Vector3 position2 = MyGarden.position;

                float distance = Vector3.Distance(position1, position2);

                if (distance < 7)
                {
                    Arrow.gameObject.SetActive(false);


                }

            }
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            line.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            goToLocation = 2;

        }
        else
        {
            if (collision.gameObject.tag == "Sell")
            {
                goToLocation = 0;
            }

        }

        if (collision.gameObject.tag == "Strawberry" || collision.gameObject.tag == "Mango" || collision.gameObject.tag == "Watermelon" || collision.gameObject.tag == "Coconut")
        {
            if(collision.gameObject.GetComponent<PlantObject>().HasMaxLevel())
            {
                goToLocation = 1;
            }
            
        }

            
        


    }
        

        
           
            
    }



        

    



    

