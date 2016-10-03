﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountdownManager : MonoBehaviour {

    [SerializeField]
    private TimeSurvived timeSurvived;

    private Text countDownText;
    private float countDown;

    // Use this for initialization
	void Start() 
	{
        timeSurvived.enabled = false;
        countDownText = GetComponent<Text>();
        countDown = 4.5f;
	}

	// Update is called once per frame
	void Update()
	{
        countDown -= Time.smoothDeltaTime;

        if(countDown >= 3.5f)
        {
            countDownText.text = "3";
        }
        else if(countDown < 3.5f && countDown >= 2.5f)
        {
            countDownText.text = "2";
        }
        else if(countDown < 2.5f && countDown >= 1.5f)
        {
            countDownText.text = "1";
        }
        else if(countDown < 1.5f && countDown >= 0.5f)
        {
            countDownText.text = "GO!";
        }
        else
        {
            countDownText.text = "";
            timeSurvived.enabled = true;
            enabled = false;
        }
	}
}