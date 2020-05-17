using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
	public GameObject prefabBala;
	public Transform cañon;
	GameObject intruso;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
	}


	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("entro");
		if (other.tag == "Enemigo")
		{
			Instantiate(prefabBala, cañon.position, cañon.rotation);
		}
	}

	void OnTriggerStay(Collider other)
	{
		if(other.tag == "Enemigo") {
			var pablosito = other.gameObject;
			intruso = pablosito;
			transform.LookAt(intruso.transform);
		}
		
	}

}
