using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// stores values used in several scenes
public class GameControl : MonoBehaviour {

	public static GameControl Instance { get; set; }
    public int BestScore { get; set; }
    public int LastScore { get; set; }

    void Awake()
    {
        // checking whether there is another GameControl object
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public static void QuitGame()
    {
        // different behavior for the editor and the application
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
