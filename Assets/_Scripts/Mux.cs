using UnityEngine;
using System.Collections;

public class Mux : MonoBehaviour 
{
	public adderV1 _adderV1;
	public adderv2 _adderv2;
	public adderV3 _adderV3;
	public adderV4 _adderV4;

	public GameObject AndPanel;
	public GameObject OrPanel;
	public GameObject SumPanel;
	public GameObject SubPanel;

	public GameObject AndWire;
	public GameObject OrWire;
	public GameObject SumWire;
	public GameObject SubWire;

	public GameObject resultPanel;
	public GameObject resultWire;

	public GameObject resultPanel2;
	public GameObject resultWire2;

	public GameObject resultPanel3;
	public GameObject resultWire3;

	public GameObject resultPanel4;
	public GameObject resultWire4;

	bool AndPanelIsOn;
	bool OrPanelIsOn;
	bool sumPanelIsOn;

	public bool SumPanelIsOn {
		get {
			return sumPanelIsOn;
		}
		set {
			sumPanelIsOn = value;
		}
	}

	bool subPanelIsOn;

	public bool SubPanelIsOn {
		get {
			return subPanelIsOn;
		}
		set {
			subPanelIsOn = value;
		}
	}

	bool resultIsOn;

	public bool ResultIsOn {
		get {
			return resultIsOn;
		}
		set {
			resultIsOn = value;
		}
	}

	bool resultIsOn2;

	public bool ResultIsOn2 {
		get {
			return resultIsOn2;
		}
		set {
			resultIsOn2 = value;
		}
	}

	bool resultIsOn3;

	public bool ResultIsOn3 {
		get {
			return resultIsOn3;
		}
		set {
			resultIsOn3 = value;
		}
	}

	bool resultIsOn4;

	public bool ResultIsOn4 {
		get {
			return resultIsOn4;
		}
		set {
			resultIsOn4 = value;
		}
	}

	// Use this for initialization
	void Start () 
	{
		bools ();

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Shortcuts();
		ResultsBools();
		Mux1();
		Result();
	}
	void bools()
	{
		AndPanelIsOn = false;
		OrPanelIsOn = false;
		sumPanelIsOn = false;
		subPanelIsOn = false;
		resultIsOn = false;
		resultIsOn2 = false;
		resultIsOn3 = false;
		resultIsOn4 = false;

	}

	void Shortcuts()
	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			if(AndPanelIsOn == false)
			{
				AndPanelIsOn = true;
				
			}
			else
			{
				AndPanelIsOn = false;
				
			}
		}
		
		if(Input.GetKeyDown(KeyCode.W))
		{
			if(OrPanelIsOn == false)
			{
				OrPanelIsOn = true;
				
			}
			else
			{
				OrPanelIsOn = false;
				
			}
		}
		if(Input.GetKeyDown(KeyCode.E))
		{
			if(sumPanelIsOn == false)
			{
				sumPanelIsOn = true;
				
			}
			else
			{
				sumPanelIsOn = false;
				
			}
		}
		
		if(Input.GetKeyDown(KeyCode.R))
		{
			if(subPanelIsOn == false)
			{
				subPanelIsOn = true;
				
			}
			else
			{
				subPanelIsOn = false;
				
			}
		}
	}

	void Mux1()
	{
		if(AndPanelIsOn == true)
		{
			
			AndPanel.GetComponent<Renderer>().material.color = Color.green;
			AndWire.GetComponent<Renderer>().material.color = Color.green;

			OrPanelIsOn = false;
			sumPanelIsOn = false;
			subPanelIsOn = false;

			
		}
		else
		{
			AndPanel.GetComponent<Renderer>().material.color = Color.red;
			AndWire.GetComponent<Renderer>().material.color = Color.red;

			AndPanelIsOn = false;
		}

		if(OrPanelIsOn == true)
		{
			
			OrPanel.GetComponent<Renderer>().material.color = Color.green;
			
			OrWire.GetComponent<Renderer>().material.color = Color.green;

			AndPanelIsOn = false;
			sumPanelIsOn = false;
			subPanelIsOn = false;

			
		}
		else
		{
			OrPanel.GetComponent<Renderer>().material.color = Color.red;
			OrWire.GetComponent<Renderer>().material.color = Color.red;	

			OrPanelIsOn = false;
		}

		if(sumPanelIsOn == true)
		{
			
			SumPanel.GetComponent<Renderer>().material.color = Color.green;
			
			SumWire.GetComponent<Renderer>().material.color = Color.green;
			
			AndPanelIsOn = false;
			OrPanelIsOn = false;
			subPanelIsOn = false;
			
			
		}
		else
		{
			SumPanel.GetComponent<Renderer>().material.color = Color.red;
			
			SumWire.GetComponent<Renderer>().material.color = Color.red;	

			sumPanelIsOn = false;
		}

		if(subPanelIsOn == true)
		{
			
			SubPanel.GetComponent<Renderer>().material.color = Color.green;
			
			SubWire.GetComponent<Renderer>().material.color = Color.green;
			
			AndPanelIsOn = false;
			OrPanelIsOn = false;
			sumPanelIsOn = false;
			
			
		}
		else
		{
			SubPanel.GetComponent<Renderer>().material.color = Color.red;
			
			SubWire.GetComponent<Renderer>().material.color = Color.red;	

			subPanelIsOn = false;
		}
	}

	 void ResultsBools()
	{

		bool Andon = _adderV1.IntermidiateWire005IsOn1;
		bool OrOn = _adderV1.IntermidiateWire006IsOn1;
		bool SumOn = _adderV1.ResultPanelIsOn;
		bool SubOn = _adderV1.ResultSubPanelIsOn;
	

		if((Andon && AndPanelIsOn)||(OrOn && OrPanelIsOn)||(SumOn && sumPanelIsOn)||(SubOn && subPanelIsOn))
		{
			resultIsOn = true;
		}
		else
		{
			resultIsOn = false;
		}

		bool Andon2 = _adderv2.IntermidiateWire005IsOn1;
		bool OrOn2 = _adderv2.IntermidiateWire006IsOn1;
		bool SumOn2 = _adderv2.ResultPanelIsOn;
		bool SubOn2 = _adderv2.ResultSubPanelIsOn;

		if((Andon2 && AndPanelIsOn)||(OrOn2 && OrPanelIsOn)||(SumOn2 && sumPanelIsOn)||(SubOn2 && subPanelIsOn))
		{
			resultIsOn2 = true;
		}
		else
		{
			resultIsOn2 = false;
		}

		bool Andon3 = _adderV3.IntermidiateWire005IsOn1;
		bool OrOn3 = _adderV3.IntermidiateWire006IsOn1;
		bool SumOn3 = _adderV3.ResultPanelIsOn;
		bool SubOn3 = _adderV3.ResultSubPanelIsOn;
		
		if((Andon3 && AndPanelIsOn)||(OrOn3 && OrPanelIsOn)||(SumOn3 && sumPanelIsOn)||(SubOn3 && subPanelIsOn))
		{
			resultIsOn3 = true;
		}
		else
		{
			resultIsOn3 = false;
		}

		bool Andon4 = _adderV4.IntermidiateWire005IsOn1;
		bool OrOn4 = _adderV4.IntermidiateWire006IsOn1;
		bool SumOn4 = _adderV4.ResultPanelIsOn;
		bool SubOn4 = _adderV4.ResultSubPanelIsOn;
		
		if((Andon4 && AndPanelIsOn)||(OrOn4 && OrPanelIsOn)||(SumOn4 && sumPanelIsOn)||(SubOn4 && subPanelIsOn))
		{
			resultIsOn4 = true;
		}
		else
		{
			resultIsOn4 = false;
		}

	}

	void Result()
	{
		if(resultIsOn)
		{
			resultPanel.GetComponent<Renderer>().material.color = Color.green;
			resultWire.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			resultPanel.GetComponent<Renderer>().material.color = Color.red;
			resultWire.GetComponent<Renderer>().material.color = Color.red;
		}

		if(resultIsOn2)
		{
			resultPanel2.GetComponent<Renderer>().material.color = Color.green;
			resultWire2.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			resultPanel2.GetComponent<Renderer>().material.color = Color.red;
			resultWire2.GetComponent<Renderer>().material.color = Color.red;
		}

		if(resultIsOn3)
		{
			resultPanel3.GetComponent<Renderer>().material.color = Color.green;
			resultWire3.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			resultPanel3.GetComponent<Renderer>().material.color = Color.red;
			resultWire3.GetComponent<Renderer>().material.color = Color.red;
		}

		if(resultIsOn4)
		{
			resultPanel4.GetComponent<Renderer>().material.color = Color.green;
			resultWire4.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			resultPanel4.GetComponent<Renderer>().material.color = Color.red;
			resultWire4.GetComponent<Renderer>().material.color = Color.red;
		}
	}

}
