using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] Slider musicSlider;
    [SerializeField] AudioMixer masterMixer;
    // Start is called before the first frame update
    private void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("SavedMasterVolume", 100));
    }

    public void SetVolume(float _value)
    {
        if(_value < 1)
        {
            _value = .001f;
        }

        RefreshSlider(_value);
        PlayerPrefs.SetFloat("SavedMasterVolume", _value);
        masterMixer.SetFloat("MasterVolume", Mathf.Log10(_value / 100) * 20f);
    }

    public void SetVolumeFromSlider() 
    {
        SetVolume(musicSlider.value);
    }

    public void RefreshSlider(float _value)
    {
        musicSlider.value = _value;
    }
}
