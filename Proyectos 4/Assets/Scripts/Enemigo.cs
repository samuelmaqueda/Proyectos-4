using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
	public float speed = 5;
	public float contador = 0;
	public float vida = 1;
	public GameObject punto2;
	public GameObject puntoFin;
	public Transform punto2Transform;
	public Transform puntoFinTransform;
	public bool llegada1;
	public GameManager gm;
	SonidosManager MR;
	// Start is called before the first frame update
	void Start()
    {
		gm = GameObject.FindObjectOfType<GameManager>();
		MR = GameObject.FindObjectOfType<SonidosManager>();

		punto2 = GameObject.Find("Punto 1");
		punto2Transform = punto2.transform;

		puntoFin = GameObject.Find("Llegada");
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
		if (this.transform.position == punto2Transform.position)
		{
			llegada1 = true;
		}

	}

	public void OnTriggerEnter(Collider other)
	{
		

		if (other.tag == "Bala")
		{
			vida--;
			MR.playDañado();
		}
		else
		{
			Debug.Log("p");
		}

		if (vida <= 0)
		{
			gm.muertes++;
			Destroy(this.gameObject);
			gm.dinero += 15;
		}
	}


}
