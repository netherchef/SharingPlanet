using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FoodState { NULL, Free, Owned }

[System.Serializable]
public enum FoodType { NULL, Rice }

[System.Serializable]
public class Food
{
	public FoodType type;
	public FoodState state;
	public float value;
	public Vector2 position;
}