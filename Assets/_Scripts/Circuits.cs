using UnityEngine;
using System.Collections;

public class Circuits : MonoBehaviour 
{
	public GameObject panel1;
	public GameObject wire1;
	public GameObject panel2;
	public GameObject wire2;
	public GameObject resultWire;
	public GameObject resultPanel;

	public GameObject panel3;
	public GameObject wire3;
	public GameObject panel4;
	public GameObject wire4;
	public GameObject resultWire2;
	public GameObject resultPanel2;

	public GameObject panel5;
	public GameObject wire5;
	public GameObject resultWire3;
	public GameObject resultPanel3;

	//public Material Changecolor;

	bool panel1IsOn;
	bool panel2IsOn;
	bool panel3IsOn;
	bool panel4IsOn;
	bool panel5IsOn;

	// Use this for initialization
	void Start () 
	{
		panel1IsOn = false;
		panel2IsOn = false;
		panel3IsOn = false;
		panel4IsOn = false;
		panel5IsOn = false;

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(panel1IsOn == true)
		{
			panel1.GetComponent<Renderer>().material.color = Color.green;
			wire1.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			panel1.GetComponent<Renderer>().material.color = Color.red;
			wire1.GetComponent<Renderer>().material.color = Color.red;

		}

		if(panel2IsOn == true)
		{
			panel2.GetComponent<Renderer>().material.color = Color.green;
			wire2.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			panel2.GetComponent<Renderer>().material.color = Color.red;
			wire2.GetComponent<Renderer>().material.color = Color.red;
			
		}
		if(panel3IsOn == true)
		{
			panel3.GetComponent<Renderer>().material.color = Color.green;
			wire3.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			panel3.GetComponent<Renderer>().material.color = Color.red;
			wire3.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(panel4IsOn == true)
		{
			panel4.GetComponent<Renderer>().material.color = Color.green;
			wire4.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			panel4.GetComponent<Renderer>().material.color = Color.red;
			wire4.GetComponent<Renderer>().material.color = Color.red;
			
		}
		if(panel5IsOn == true)
		{
			panel5.GetComponent<Renderer>().material.color = Color.green;
			wire5.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			panel5.GetComponent<Renderer>().material.color = Color.red;
			wire5.GetComponent<Renderer>().material.color = Color.red;
			
		}

		if(panel1IsOn && panel2IsOn)
		{
			resultWire.GetComponent<Renderer>().material.color = Color.green;
			resultPanel.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			resultWire.GetComponent<Renderer>().material.color = Color.red;
			resultPanel.GetComponent<Renderer>().material.color = Color.red;
		}

		if(panel3IsOn || panel4IsOn)
		{
			resultWire2.GetComponent<Renderer>().material.color = Color.green;
			resultPanel2.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			resultWire2.GetComponent<Renderer>().material.color = Color.red;
			resultPanel2.GetComponent<Renderer>().material.color = Color.red;
		}
		if(!panel5IsOn)
		{
			resultWire3.GetComponent<Renderer>().material.color = Color.green;
			resultPanel3.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			resultWire3.GetComponent<Renderer>().material.color = Color.red;
			resultPanel3.GetComponent<Renderer>().material.color = Color.red;
		}

	
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "panel1")
		{
			if(panel1IsOn == false)
			{
				panel1IsOn = true;

			}
			else
			{
				panel1IsOn = false;

			}
		}

		if(other.gameObject.tag == "panel2")
		{
			if(panel2IsOn == false)
			{
				panel2IsOn = true;

			}
			else
			{
				panel2IsOn = false;
					
			}
		}
		if(other.gameObject.tag == "panel3")
		{
			if(panel3IsOn == false)
			{
				panel3IsOn = true;
				
			}
			else
			{
				panel3IsOn = false;
				
			}
		}
		if(other.gameObject.tag == "panel4")
		{
			if(panel4IsOn == false)
			{
				panel4IsOn = true;
				
			}
			else
			{
				panel4IsOn = false;
				
			}
		}
		if(other.gameObject.tag == "panel5")
		{
			if(panel5IsOn == false)
			{
				panel5IsOn = true;
				
			}
			else
			{
				panel5IsOn = false;
				
			}
		}
		
	}
}
