using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// menu logic
public class MenuControl : MonoBehaviour {

	public void StartOnClick(string gameSceneName)
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void QuitOnClick()
    {
        GameControl.QuitGame();
    }
}
