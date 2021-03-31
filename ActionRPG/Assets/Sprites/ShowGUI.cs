using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UiObject;
    public GameObject UiObject1;
    public GameObject UiObject2;


    private void Start()
    {
        UiObject.SetActive(false);
        UiObject1.SetActive(false);
        UiObject2.SetActive(false);
    }




    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Player")
        {
            UiObject.SetActive(true);
            UiObject1.SetActive(true);
            UiObject2.SetActive(true);
        }    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UiObject.SetActive(false);
        UiObject1.SetActive(false);
        UiObject2.SetActive(false);
    }

}
