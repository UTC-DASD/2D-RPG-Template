using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject SlefObject;
    public Material sharedMaterial;

    void Start()
    {
        SlefObject.GetComponent<Renderer>().sharedMaterial.color = new Color(255, 0, 0);
    }
    void Awake()
    {
        SlefObject.GetComponent<Renderer>().sharedMaterial.color = new Color(255, 100, 0);
    /*foreach(GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
     {
        if(gameObj.name == "ColorTester")
        {
            gameObj.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
        }
     }*/

    }
}
//!!!!!!!!!!*****************!!!!! Make title screen that has a utton or switch with bool to determine color blindness (red green) and start button