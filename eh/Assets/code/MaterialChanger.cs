using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
        {
            if(gameObj.name == "Cube")
            {
                gameObj.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
            }
        }

    }
}
