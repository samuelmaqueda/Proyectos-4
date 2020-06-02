using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public void CambiarEscena1()
	{
		SceneManager.LoadScene("Buena");
	}

	public void CambiarEscenaMenu()
	{
		SceneManager.LoadScene("MENU");
	}

	public void CambiarEscena2()
	{
		SceneManager.LoadScene("Buena 2");
	}

	public void CerrarJuego()
	{
		Application.Quit();
	}


}
