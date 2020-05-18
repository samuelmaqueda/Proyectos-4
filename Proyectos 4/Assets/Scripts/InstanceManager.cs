﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceManager : MonoBehaviour
{
	public GameObject prefabTorreta;
	public GameObject prefabTorreta2;
	public GameManager gm;
	public LayerMask suelo;

	// Start is called before the first frame update
	void Start()
    {
		gm = GameObject.FindObjectOfType<GameManager>();
	}

    // Update is called once per frame
    void Update()
    {
		if (gm.dinero >= 20 && gm.torreta1Selec == true)
		{
			if (Input.GetMouseButtonDown(0))
			{
				gm.dinero -= 20;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit infoImpacto;
				if (Physics.Raycast(ray, out infoImpacto,Mathf.Infinity, suelo))
				{
					Debug.Log("impactado");
					Vector3 puntoImpacto = infoImpacto.point;
					Instantiate(prefabTorreta, puntoImpacto, Quaternion.identity);
				}
			}
		}
		else if(gm.dinero >= 40 && gm.torreta2Selec == true)
		{
			if (Input.GetMouseButtonDown(0))
			{
				gm.dinero -= 40;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit infoImpacto;
				if (Physics.Raycast(ray, out infoImpacto, Mathf.Infinity, suelo))
				{
					Debug.Log("impactado2");
					Vector3 puntoImpacto = infoImpacto.point;
					Instantiate(prefabTorreta2, puntoImpacto, Quaternion.identity);
				}
			}
		}
		
	}
}
