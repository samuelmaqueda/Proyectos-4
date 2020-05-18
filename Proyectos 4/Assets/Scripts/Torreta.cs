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
	// Start is called before the first frame update
	void Start()
    {
        
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
			}
			timer = 0;
		}

	}

}
