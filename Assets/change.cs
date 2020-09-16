using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
	public Material black;
	public Material skin;
	public Material grey;

    void Start()
    {
		transform.FindChild("polySurface1").GetComponent<Renderer>().material = grey;
		transform.FindChild("polySurface2").GetComponent<Renderer>().material = black;
		transform.FindChild("polySurface3").GetComponent<Renderer>().material = skin;

    }

    
}
