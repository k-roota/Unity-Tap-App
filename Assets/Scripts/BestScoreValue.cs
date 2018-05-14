using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// initiates best score label value
public class BestScoreValue : MonoBehaviour {

	void Start () {
        gameObject.GetComponent<Text>().text = GameControl.Instance.BestScore.ToString();
	}
}
