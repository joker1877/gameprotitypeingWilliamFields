using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float  myCoolTimer99;
    public Text timerText;
    private float myTimer;

    public object TimerText { get; private set; }


    // Use this for initialization
    void Start () {

        //TimerText = GetComponet<Text>();  
       
	}

    //private object GetComponet<T>()
    //{
        //throw new NotImplementedException();
    //}

    // Update is called once per frame
    void Update () {

        myTimer += Time.deltaTime;
        timerText.text = myTimer.ToString();
        //TimerText.text = timerText.ToString("f4");

    }
}
