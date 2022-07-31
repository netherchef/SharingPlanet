using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Directions

public enum Direction { NULL, Up, UpLeft, Left, DownLeft, Down, DownRight, Right, UpRight }

public class Utilities : MonoBehaviour
{
	public static Direction InputDirection ()
	{
		float xInput = Input.GetAxis ("Horizontal");
		float yInput = Input.GetAxis ("Vertical");

		if (xInput > 0)
		{
			if (yInput > 0) return Direction.UpRight;
			else if (yInput < 0) return Direction.DownRight;
			else return Direction.Right;
		}
		else if (xInput < 0)
		{
			if (yInput > 0) return Direction.UpLeft;
			else if (yInput < 0) return Direction.DownLeft;
			else return Direction.Left;
		}
		else
		{
			if (yInput > 0) return Direction.Up;
			else if (yInput < 0) return Direction.Down;
		}

		return default;
	}
}
