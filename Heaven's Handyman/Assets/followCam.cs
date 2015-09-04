using UnityEngine;
using System.Collections;

public class followCam : MonoBehaviour {

	public float dampTime = 0.25f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	
	void Update () 
	{
		if (target.position.x > 0)
		{
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.3f, 0.4f, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
	}
}
