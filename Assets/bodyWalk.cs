using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyWalk : MonoBehaviour {
    private HeadLook_walk lookWalk;
    //private AudioSource footstepAudio;
    private Transform head;
    private Transform body;

    // Use this for initialization
    void Start () {
        lookWalk = GetComponent<HeadLook_walk>();
        //footstepAudio = GameObject.Find("GameController").GetComponent<AudioSource>();
        //footstepAudio = GetComponent<AudioSource>();
        head = Camera.main.transform;
        body = transform.Find("MyBody");

    }
	
	// Update is called once per frame
	void Update () {
		if(lookWalk.isWalking)
        {
            body.transform.rotation = 
                Quaternion.Euler(new Vector3(0.0f, head.transform.eulerAngles.y, 0.0f));
            //if (!footstepAudio.isPlaying)
            //{
            //    footstepAudio.Play();
            //}
        }
        //else
        //{
        //    footstepAudio.Stop();
        //}
    }
}
