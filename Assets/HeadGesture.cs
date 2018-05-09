using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeadGesture : MonoBehaviour {
    //通过头部的快速向下，从而确定是否打开开关(修改is movingDown 的属性)
    
    public bool isMovingDown = false;
    //脸是否朝下
    public bool isFacingDown = false;
    //前后相差100 度
    public float sweepRate = 100.0f;
    private float previousCameraAngle;

    void Start()
    {
        previousCameraAngle = CameraAngleFromGround();
    }

    void Update()
    {
        isFacingDown = DetectFacingDown();
        isMovingDown = DetectNoddingDown(); // isNoddingDown
    }

    private float CameraAngleFromGround()
    {
        return Vector3.Angle(Vector3.down, Camera.main.transform.rotation * Vector3.forward);
    }
    private bool DetectFacingDown()
    {
        return (CameraAngleFromGround() < 60.0f);
    }
    private bool DetectNoddingDown()
    {
        float angle = CameraAngleFromGround();
        float deltaAngle = previousCameraAngle - angle;
        float rate = deltaAngle / Time.deltaTime;
        previousCameraAngle = angle;
        return (rate >= sweepRate);
    }
}
