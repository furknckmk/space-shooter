﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemaslaYokOl : MonoBehaviour
 {
public GameObject patlama;
public GameObject playerPatlama;
GameObject OyunKontrol;
OyunKontrol kontrol;

void Start()
{
	OyunKontrol=GameObject.FindGameObjectWithTag("OyunKontrol");
	kontrol=OyunKontrol.GetComponent<OyunKontrol>();
	
}
void OnTriggerEnter(Collider col)
{
	if (col.tag!="Sinir")
	{
		Destroy(col.gameObject);
	Destroy (gameObject);
	Instantiate (patlama,transform.position,transform.rotation);
	kontrol.ScoreArttir(10);
	}
	if (col.tag=="Player")
	{
		Instantiate (playerPatlama,col.transform.position,col.transform.rotation);
		kontrol.oyunBitti();
	}
}
	
	
}
