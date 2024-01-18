using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialChanger : MonoBehaviour
{
    public static bool isCool = false;
    public Toggle myToggle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(myToggle.isOn)
        {
        foreach(GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
        {
            if(gameObj.name == "Bad Guy")
            {
                gameObj.GetComponent<Renderer>().material.color = new Color(0, 204, 0);
                isCool = true;
            }
        }
        }
        else
        {
            isCool = false;
        }
        

    }
}
