using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyStuff : MonoBehaviour
{
    public static float diff = 1f;
    //public Dropdown uiDropdown;
    public Toggle myToggle;
    void Awake()
    {

//        Dropdown uiDropdown = Dropdown.Find("DropIt").GetComponent<Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (uiDropdown.value == 1)
        {
        diff = .5f;
        Debug.Log("easy");
        }
        if (uiDropdown.value == 2)
        {
        diff = 1f;
        Debug.Log("normal");
        }
        if (uiDropdown.value == 3)
        {
        diff = 2f;
        Debug.Log("hard");
        }*/
        if(myToggle.isOn)
        {
        diff = 2f;
        Debug.Log("hard");
        }
        else
        {
        diff = 1f;
        Debug.Log("normal");
        }

    }
}
