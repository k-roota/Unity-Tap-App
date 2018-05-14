using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// initiates last score label value
public class LastScoreValue : MonoBehaviour {

	void Start () {
        gameObject.GetComponent<Text>().text = GameControl.Instance.LastScore.ToString();
	}
	
}
