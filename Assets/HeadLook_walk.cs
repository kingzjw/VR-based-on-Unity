using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLook_walk : MonoBehaviour {

    public float velocity = 0.7f;
    private CharacterController controller;

    //控制是否移动
    //public bool isWalking = false;
    public bool isWalking = true;
    //private Camera camera;
    //private CharacterController controller;
    //private AudioSource footsteps;
    //private GameObject head;
    //private GameObject body;
    //private HeadGesture gesture;
    //private bool walking;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        //camera = GameObject.FindWithTag("MeCamera").GetComponent<Camera>();
        //footsteps = GetComponent<AudioSource>();
        //head = GameObject.FindWithTag("MeHead");
        //body = GameObject.FindWithTag("MeBody");
        //gesture = GameObject.Find("GameController").GetComponent<HeadGesture>();
        //walking = false;
    }

    void Update()
    {
        //way 1
        
        //Vector3 moveDirection = Camera.main.transform.forward;
        //moveDirection *= velocity * Time.deltaTime;
        ////当前这个game object的坐标
        //moveDirection.y = 0.0f;
        ////transform.position += moveDirection;
        //controller.Move(moveDirection);

        //way 2

        if(isWalking)
        {
            controller.SimpleMove(Camera.main.transform.forward * velocity);
        }
    }
}
