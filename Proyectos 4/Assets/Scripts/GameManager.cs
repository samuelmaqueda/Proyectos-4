using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public GameObject enemigo;
	public Transform spawn;
	public float vida = 10;
	public float dinero = 100;
	public Text vidaText;
	public Text dineroText;
	public float timer;
	public SimpleHealthBar healthBar;
	Transform fin;
	public Torreta torreta;
    // Start is called before the first frame update
    void Start()
    {

		torreta = GameObject.FindObjectOfType<Torreta>();

	}

    // Update is called once per frame
    void Update()
    {
		vidaText.text = (vida + "/10");
		dineroText.text = (dinero + "");

		timer += Time.deltaTime;

		if (timer >= 2f)
		{
			Instantiate(enemigo, spawn.position, Quaternion.identity);
			timer = 0;
		}

		healthBar.UpdateBar(vida, 10f);
	}

	public void AumetarCadencia()
	{
		if(dinero >= 100)
		{
			dinero -= 100;
			torreta.cadencia -= 0.5f;
		}
	}
}
