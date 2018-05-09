using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippinDashboard : MonoBehaviour {
    //这两个类都是自定义的
    private HeadGesture gesture;
    private GameObject dashboard;
    private bool isOpen = true;
    private Vector3 startRotation;

	void Start() {
        gesture = GetComponent<HeadGesture>();
        dashboard = GameObject.Find("Dashboard");
		startRotation = dashboard.transform.eulerAngles;
        CloseDashboard();
    }

	void Update() {
		if(gesture.isFacingDown)
        {
            Debug.Log("open the dashboard");
            OpenDashboard();
        }else
        {
           // Debug.Log("close the dashboard");
            CloseDashboard();
        }
	}
	private void CloseDashboard() {
		if (isOpen) {
            Debug.Log("is open need to close  the dashboard");
            gameObject.transform.eulerAngles = new Vector3 (180f, startRotation.y, startRotation.z);
			isOpen = false;
		}
	}

	private void OpenDashboard() {
		if (!isOpen) {
			gameObject.transform.eulerAngles = startRotation;
			isOpen = true;
			//timer = 3.0f;
		}
	}
}
