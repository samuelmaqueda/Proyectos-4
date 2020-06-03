using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
	public GameObject prefabBala;
	public Transform cañon;
	GameObject intruso;
	public float timer;
	public Collider enemigo;
	public float cadencia;
	SonidosManager MR;
	// Start is called before the first frame update
	void Start()
    {
		MR = GameObject.FindObjectOfType<SonidosManager>();
	}

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
	}


	private void OnTriggerEnter(Collider other)
	{
		enemigo = other;
		//if (other.tag == "Enemigo")
		//{
		//	Instantiate(prefabBala, cañon.position, cañon.rotation);
		//}
	}

	void OnTriggerStay(Collider other)
	{
		if(other.tag == "Enemigo") {
			var pablosito = other.gameObject;
			intruso = pablosito;
			transform.LookAt(intruso.transform);
		}

		if (timer >= cadencia)
		{
			if (enemigo.tag == "Enemigo")
			{
				Instantiate(prefabBala, cañon.position, cañon.rotation);
				MR.playDisparo();
			}
			timer = 0;
		}

	}

}
