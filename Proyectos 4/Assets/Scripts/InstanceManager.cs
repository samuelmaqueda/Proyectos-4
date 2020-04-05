using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceManager : MonoBehaviour
{
	public GameObject prefabTorreta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("pulsado");
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit infoImpacto;
			if (Physics.Raycast(ray, out infoImpacto))
			{
				Debug.Log("impactado");
				Vector3 puntoImpacto = infoImpacto.point;
				Instantiate(prefabTorreta, puntoImpacto, Quaternion.identity);
			}
		}
	}
}
