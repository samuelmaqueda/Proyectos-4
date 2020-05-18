﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
	public float speed = 5;
	public float vida = 1;
	public GameObject punto1;
	public GameObject punto2;
	public GameObject puntoFin;
	public Transform punto1Transform;
	public Transform punto2Transform;
	public Transform puntoFinTransform;
	public bool llegada1;
	public bool llegada2;
	public GameManager gm;
	// Start is called before the first frame update
	void Start()
	{
		gm = GameObject.FindObjectOfType<GameManager>();

		punto1 = GameObject.Find("Punto 1b");
		punto1Transform = punto1.transform;

		punto2 = GameObject.Find("Punto 2b");
		punto2Transform = punto2.transform;

		puntoFin = GameObject.Find("Punto finb");
		puntoFinTransform = puntoFin.transform;
	}

	// Update is called once per frame
	void Update()
	{
		Comprobacion();
		Patrulla();

	}

	public void Patrulla()
	{
		float step = speed * Time.deltaTime;
		if (llegada1 == false)
		{
			transform.position = Vector3.MoveTowards(transform.position, punto1Transform.position, step);
			transform.LookAt(punto1.transform);
		}
		else if (llegada1 == true && llegada2 == false)
		{
			transform.position = Vector3.MoveTowards(transform.position, punto2Transform.position, step);
			transform.LookAt(punto2.transform);
		}
		else 
		{
			transform.position = Vector3.MoveTowards(transform.position, puntoFinTransform.position, step);
			transform.LookAt(puntoFin.transform);

			if (this.transform.position == puntoFinTransform.position)
			{
				Debug.Log("fin");
				gm.vida -= 1;
				Destroy(this.gameObject);
			}
		}

	}

	public void Comprobacion()
	{
		if (this.transform.position == punto1Transform.position)
		{
			llegada1 = true;
		}
		else if (this.transform.position == punto2Transform.position)
		{
			llegada2 = true;
		}

	}

	public void OnTriggerEnter(Collider other)
	{


		if (other.tag == "Bala")
		{
			vida--;
		}
		else
		{
			Debug.Log("p");
		}

		if (vida <= 0)
		{
			Destroy(this.gameObject);
		}
	}
}