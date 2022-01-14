using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroLevel : MonoBehaviour {

	public void SettingsClick()
    {
        SceneManager.LoadScene("Settings");
    }

    public void RotatedLevelClick()
    {
        SceneManager.LoadScene("rotatedPathsLevel");
    }
	
	public void QuitClick()
	{
		Application.Quit();
	}
}
