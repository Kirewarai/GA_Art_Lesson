using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Using namespaces prevent collisions between class names
// E.g. you can have multiple classes called Vector2
namespace GA.Snake2021
{
	// All classes which should be attachable to GameObjects have to be derived from MonoBehaviour
	public class SnakeController : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
			Debug.Log("Snake loaded");
		}
	}
}