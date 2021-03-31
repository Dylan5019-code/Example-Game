using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardEventHandler : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject UiObject1;
    public GameObject UiObject2;
    public GameObject enemy; 
    public int computerChoice;


    private void Start()
    {
        computerChoice = Random.Range(1, 4);
    }


    public void pickRock()
    {
        Debug.Log("You Choose Rock");
        chooseAction(1);
        //hideUi();

    }

    public void pickPaper()
    {
        Debug.Log("You Choose Paper");
        chooseAction(2);
        //hideUi();
    }

    public void pickScissors()
    {
        Debug.Log("You Choose Scissors");
        chooseAction(3);
        //hideUi();
    }

    void chooseAction(int choice)
    {
        
        if (choice == 1)
        {
            UiObject.SetActive(false);
            Destroy(enemy);
        }
        else if (choice == 2)
        {
            UiObject1.SetActive(false);
            Destroy(enemy);
        }
        else if (choice == 3)
        {
            UiObject2.SetActive(false);
            Destroy(enemy);
        }
        else
        {
            Debug.Log("Error");
        }

    }


}
