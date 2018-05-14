using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// behavior of button which opens menu
public class MenuButtonControl : MonoBehaviour {

	public void MenuButtonOnCLick(string menuSceneName)
    {
        SceneManager.LoadScene(menuSceneName);
    }
}
