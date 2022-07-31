using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	private float moveSpeed = 2f;

	private void Update ()
	{
		transform.position += new Vector3 (
			Input.GetAxis ("Horizontal"), 
			Input.GetAxis ("Vertical")) * moveSpeed * Time.deltaTime;
	}
}