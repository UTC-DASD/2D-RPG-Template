using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SettingsToMain : MonoBehaviour 
{
	public Button yourButton;

	void Start () 
    {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
    {
		SceneManager.LoadScene(3);
	}
}