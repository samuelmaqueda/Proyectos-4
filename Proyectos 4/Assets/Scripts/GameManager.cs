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

	Transform fin;
    // Start is called before the first frame update
    void Start()
    {
		
		Instantiate(enemigo, spawn.position, Quaternion.identity);

	}

    // Update is called once per frame
    void Update()
    {
		vidaText.text = (vida + " puntos de vida");
		dineroText.text = (dinero + " oro");
	}
}
