using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureWalk : MonoBehaviour {
    //前面定义的走路的脚本对象,头部脚本
    private HeadLook_walk lookWalk;
    private HeadGesture gesture;

    // Use this for initialization
    void Start () {
        //拿到当前vr场景中的两个对象
        lookWalk = GetComponent<HeadLook_walk>();
        gesture = GameObject.Find("GameController").GetComponent<HeadGesture>();
    }
	
	// Update is called once per frame
	void Update () {
		if(gesture.isMovingDown)
        {
            lookWalk.isWalking = !lookWalk.isWalking;
        }
	}
}
