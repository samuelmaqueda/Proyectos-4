using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
	public float speed = 10;



	private void Update()
	{
		transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

	public void OnTriggerEnter(Collider other)
	{
		Destroy(this.gameObject);
	}
}
