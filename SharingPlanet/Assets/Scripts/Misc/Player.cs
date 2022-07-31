using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Person Ego { get { return GetComponent<Person> (); } }

	[SerializeField]
	private List<Food> foods = new List<Food> ();

	private void Update ()
	{
		if (Input.GetButtonDown ("Submit"))
		{
			Food newFood = Universe.Get_Food_Near_Point (transform.position);

			if (newFood != null) foods.Add (newFood);
		}
	}

	private void Give ()
	{

	}

	private void Drop ()
	{

	}
}