using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
	public Material yellow;
	public Material black;
	public Material skin;
	public Material grey;

    void Start()
    {
		transform.FindChild("Body").GetComponent<Renderer>().material = yellow;
		transform.FindChild("head").GetComponent<Renderer>().material = skin;
		transform.FindChild("Left_Am").GetComponent<Renderer>().material = skin;
		transform.FindChild("Left_foot").GetComponent<Renderer>().material = grey;
		transform.FindChild("Left_Hand_").GetComponent<Renderer>().material = skin;
		transform.FindChild("Left_leg").GetComponent<Renderer>().material =black;
		transform.FindChild("Right_arm").GetComponent<Renderer>().material =skin;
		transform.FindChild("Right_foot").GetComponent<Renderer>().material = grey;
		transform.FindChild("Right_hand").GetComponent<Renderer>().material = skin;
		transform.FindChild("Right_leg").GetComponent<Renderer>().material = black;
    }

    
}
