using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemaslaYokOl : MonoBehaviour
 {
public GameObject patlama;
public GameObject playerPatlama;
void OnTriggerEnter(Collider col)
{
	if (col.tag!="Sinir")
	{
		Destroy(col.gameObject);
	Destroy (gameObject);
	Instantiate (patlama,transform.position,transform.rotation);
	}
	if (col.tag=="Player")
	{
		Instantiate (playerPatlama,col.transform.position,col.transform.rotation);
	}
}
	
	
}
