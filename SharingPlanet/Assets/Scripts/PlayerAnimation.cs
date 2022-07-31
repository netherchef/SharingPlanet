using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Sprite up, down, left, right, upLeft, downLeft, upRight, downRight;

	private void Update ()
	{
		Direction direction = Utilities.InputDirection ();

		switch (direction)
		{
			case Direction.Up:
				spriteRenderer.sprite = up;
				break;
			case Direction.Down:
				spriteRenderer.sprite = down;
				break;
			case Direction.Left:
				spriteRenderer.sprite = left;
				break;
			case Direction.Right:
				spriteRenderer.sprite = right;
				break;
			case Direction.UpLeft:
				spriteRenderer.sprite = upLeft;
				break;
			case Direction.DownLeft:
				spriteRenderer.sprite = downLeft;
				break;
			case Direction.UpRight:
				spriteRenderer.sprite = upRight;
				break;
			case Direction.DownRight:
				spriteRenderer.sprite = downRight;
				break;
		}
	}
}
