using UnityEngine;
using System.Collections;

public class DigitValue2 : MonoBehaviour 
{
	//public adderv2 _adderV2;
	public Mux _mux;
	public TextMesh tm;
	public int binaryPart;
	
	
	void Start () 
	{
		tm = (TextMesh)GameObject.Find("2ndDigit").GetComponent<TextMesh>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		bool Digit = _mux.ResultIsOn2;
		if(Digit == true)
		{
			tm.text = "1";
			binaryPart = 1;
		}
		else
		{
			tm.text = "0";
			binaryPart = 0;
		}
		
		
	}
}
