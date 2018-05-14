using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TapCounter : MonoBehaviour {

    public string nextSceneName;
    public Text scoreText;
    public Slider slider;
    public float timeLimit;

    float startTime;

    int TapCount
    {
        get
        {
            return tapCount;
        }
        set
        {
            tapCount = value;
            // text on label the same as tapCount
            scoreText.text = tapCount.ToString();
        }
    }

    int tapCount;

    void Start () {
        TapCount = 0;
        startTime = Time.time;
    }
	
	void Update () {
        slider.value = 1 - (Time.time - startTime) / timeLimit;
        // if time has ended
        if (slider.value == 0)
        {
            // setting values in GameControl
            if (TapCount > GameControl.Instance.BestScore)
            {
                GameControl.Instance.BestScore = TapCount;
            }
            GameControl.Instance.LastScore = TapCount;
            SceneManager.LoadScene(nextSceneName);
        }

        /* Counts a new tap
        Compatible with touch and mouse devices */
        if (Input.GetMouseButtonUp(0))
        {
            TapCount++;
        }
	}
}
