using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour {

    public GameObject scorePanel;
    public string idleStateName;
    public string moveTriggerName;

    Animator animator;
    Text label;
    List<string> countLabels;
    int labelID; // current label index
    int idleState;
    int moveTrigger;

    void Start () {
        animator = gameObject.GetComponent<Animator>();
        label = gameObject.GetComponent<Text>();
        countLabels = new List<string>() { "3", "2", "1", "START" };
        labelID = 0;
        idleState = Animator.StringToHash(idleStateName);
        moveTrigger = Animator.StringToHash(moveTriggerName);
    }
	
	void Update () {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.shortNameHash == idleState && !animator.IsInTransition(0))
        {
            if(labelID < countLabels.Count)
            {
                // changing the label on the idle state
                label.text = countLabels[labelID++];
                animator.SetTrigger(moveTrigger);
            }
            else
            {
                // showing a panel with score after all labels have been shown
                scorePanel.SetActive(true);
                Destroy(gameObject);
            }
        }
	}
}
