using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevate : MonoBehaviour {

    // Use this for initialization
    public float minHeight = 0.0f;
    public float maxHeight = 8.0f;
    public float velocity = 1;
    //最高和最低的地方暂停的时间
    public float timeDelay = 1.5f;
	void Update () {
        if(timeDelay<0)
        {
            float y = transform.position.y;
            y += velocity + Time.deltaTime;
            if(y>maxHeight)
            {
                y = maxHeight;
                velocity = -velocity;
                timeDelay = 1.5f;
            }
            if(y<minHeight)
            {
                y = minHeight;
                velocity = -velocity;
                timeDelay = 5f;
            }
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }else
        {
            timeDelay -= Time.deltaTime;
        }
	}
}
