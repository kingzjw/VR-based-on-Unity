using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{

	// Use this for initialization
	void Start () {
        StartCoroutine(RePositionWithDely());
	}

    IEnumerator RePositionWithDely()
    {
        while(true)
        {
            setRandomPosition();
            yield return new WaitForSeconds(5);
        }
    }

    void setRandomPosition()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-5.0f, 5.0f);
        Debug.Log("X,Z: " + x + ", " + z);
        transform.position = new Vector3(x, 0.0f, z);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
