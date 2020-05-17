using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public GameObject enemigo;
	public Transform spawn;
	public float vida = 1;
	public float dinero = 100;
	public Text vidaText;
	public Text dineroText;
	public float timer;

	Transform fin;
    // Start is called before the first frame update
    void Start()
    {
		
		

	}

    // Update is called once per frame
    void Update()
    {
		vidaText.text = (vida + " puntos de vida");
		dineroText.text = (dinero + " oro");

		timer += Time.deltaTime;
		if (timer >= 2)
		{
			Instantiate(enemigo, spawn.position, Quaternion.identity);
			timer = 0;
		}
	}
}
