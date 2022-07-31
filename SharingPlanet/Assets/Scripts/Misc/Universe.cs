using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe : MonoBehaviour
{
	[SerializeField]
	private bool createFood;

    private static List<Food> foodPool = new List<Food> ();

	private void OnDrawGizmos ()
	{
		foreach (Food food in foodPool)
		{
			Gizmos.DrawWireSphere (food.position, 0.1f);
		}
	}

	private void Update ()
	{
		if (createFood)
		{
			Food newFood = new Food {
				type = FoodType.Rice,
				state = FoodState.Free, 
				value = 1f, 
				position = Random.insideUnitCircle };

			foodPool.Add (newFood);

			createFood = false;
		}
	}

	public static Food Get_Food_Near_Point (Vector2 point)
	{
		foreach (Food food in foodPool)
		{
			if (Vector2.Distance (food.position, point) < 0.2f) return food;
		}

		return null;
	}
}
