using System.Collections;
using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject Ball;

    private Vector3 Offset;

	// Use this for initialization
	void Start ()
    {
        Offset = transform.position - Ball.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = Ball.transform.position + Offset;
	}
}
