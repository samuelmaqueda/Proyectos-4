using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject enemigo;
	public GameObject enemigo2;
	public Transform spawn;
	public Transform spawn2;
	public float vida = 10;
	public float dinero = 100;
	public Text vidaText;
	public Text dineroText;
	public float timer;
	public SimpleHealthBar healthBar;
	Transform fin;
	Torreta torreta;
	public bool torreta1Selec = true;
	public bool torreta2Selec;
	public bool torreta3Selec;
	public float muertes;
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

		if (timer >= 3f)
		{
			Instantiate(enemigo, spawn.position, Quaternion.identity);
			Instantiate(enemigo2, spawn2.position, Quaternion.identity);
			timer = 0;
		}

		healthBar.UpdateBar(vida, 10f);

		if (vida <= 0)
		{
			SceneManager.LoadScene("GG");
		}

		if (muertes >= 30)
		{
			SceneManager.LoadScene("MENU");
		}
	}

	public void AumetarCadencia()
	{
		if(dinero >= 200)
		{
			dinero -= 200;
			torreta.cadencia -= 0.5f;
		}
	}

	public void seleccionarTorreta1()
	{
		torreta1Selec = true;
		torreta2Selec = false;
		torreta3Selec = false;
	}

	public void seleccionarTorreta2()
	{
		torreta1Selec = false;
		torreta2Selec = true;
		torreta3Selec = false;
	}

	public void seleccionarTorreta3()
	{
		torreta1Selec = false;
		torreta2Selec = false;
		torreta3Selec = true;
	}
}
