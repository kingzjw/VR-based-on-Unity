using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour
{

    public GameObject ground;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform camera = Camera.main.transform;//当前相机的transform组件
        Ray ray;
        RaycastHit[] hits;
        GameObject hitObject;

        //scene 
        Debug.DrawRay(camera.transform.position, camera.transform.rotation * Vector3.forward * 100.0f);

        ray = new Ray(camera.transform.position, camera.transform.rotation * Vector3.forward);

        hits = Physics.RaycastAll(ray);
        for (int i = 0; i < hits.Length; i++)
        {
            hitObject = hits[i].collider.gameObject;
            if (hitObject == ground)
            {
                Debug.Log("Hit (x,y,z): " + hits[i].point.ToString("F2"));
                transform.position = hits[i].point;
            }

        }
    }
}