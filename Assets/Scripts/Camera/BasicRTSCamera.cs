using UnityEngine;
using System.Collections;

public class BasicRTSCamera : MonoBehaviour {

	public float maxXPosition;
	public float maxYPosition;
	public float maxZPosition;

	public float minXPosition;
	public float minYPosition;
	public float minZPosition;

	public float moveSpeed;

	private Vector3 startPosition;

	void Start () {
		startPosition = transform.position;
	}
	
	void Update () {
		if (Input.GetKey("left") && transform.position.x < maxXPosition) {
			transform.position = new Vector3(transform.position.x + Time.deltaTime * moveSpeed, transform.position.y, transform.position.z);
		}
		if (Input.GetKey("right") && transform.position.x > minXPosition) {
			transform.position = new Vector3(transform.position.x - Time.deltaTime * moveSpeed, transform.position.y, transform.position.z);
		}
		if (Input.GetKey("down") && transform.position.x > minZPosition) {
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime * moveSpeed);
		}
		if (Input.GetKey("up") && transform.position.x < maxZPosition) {
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Time.deltaTime * moveSpeed);
		}
	}
}
