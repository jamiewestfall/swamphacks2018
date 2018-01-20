using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class countQuestions : MonoBehaviour {
    public Text countText;
    int questionAmount;
    public GameObject doneAddingScreen;
    public GameObject questionPanel;
    private bool sessionInProgress;
    
    Component[] inputfields;
    int count;
	// Use this for initialization
	void Start () {
        sessionInProgress = false;
        questionAmount = 0;
        count = 1;
        inputfields = questionPanel.GetComponentsInChildren<InputField>();
	}
	
	// Update is called once per frame
	void Update () {
        countText.text = count + " / " + questionAmount;

        if (count == questionAmount + 1 && sessionInProgress) {
            doneAddingScreen.SetActive(true);
            count = 1;
        }
	}

    public void setQuestionamount() {
        questionAmount = Convert.ToInt32(GameObject.Find("answer").GetComponent<Text>().text); 
    }

    public void increaseCount() {
        count++;
    }
    public void resetQPanel() {
        increaseCount();
        foreach (InputField inp in inputfields) {

            inp.text = "";

        }

    }
    public void initialize() {
        sessionInProgress = true;
    }
}
