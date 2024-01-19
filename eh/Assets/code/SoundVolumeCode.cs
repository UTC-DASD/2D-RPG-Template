using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVolumeCode : MonoBehaviour
{
    public static float m_MusicCool;

    void Start()
    {
        //Start the Camera field of view at 60
        m_MusicCool = 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        //Set up the maximum and minimum values the Slider can return (you can change these)
        float max, min;
        max = 100.0f;
        min = 40.0f;
        //This Slider changes the field of view of the Camera between the minimum and maximum values
        m_MusicCool = GUI.HorizontalSlider(new Rect(547, 501.4f, 435, 40), m_MusicCool, min, max);
    }
}
//47f, 100f, 435, 40
