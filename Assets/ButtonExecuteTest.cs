using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonExecuteTest : MonoBehaviour {
    private GameObject startButton, stopButton;
    private bool on = false;
    public float timer = 5.0f;

    void Start()
    {
       startButton = GameObject.Find("StartButton");
       stopButton = GameObject.Find("StopButton");
    }

    void Update()
    {
        //Debug.Log("update", gameObject);
        timer -= Time.deltaTime;
        if (timer < 0.0f)
        {
            if (on)
            {
                Debug.Log("need to close the gate", gameObject);
            }
            else
            {
                Debug.Log("need to open the gate", gameObject);
            }
            on = !on;
            timer = 5.0f;

            PointerEventData data = new PointerEventData(EventSystem.current);
            if (on)
            {
                ExecuteEvents.Execute<IPointerClickHandler>(startButton, data, ExecuteEvents.pointerClickHandler);
            }
            else
            {
                ExecuteEvents.Execute<IPointerClickHandler>(stopButton, data, ExecuteEvents.pointerClickHandler);
            }
        }

    }
}
