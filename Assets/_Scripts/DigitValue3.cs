using UnityEngine;
using System.Collections;

public class DigitValue3 : MonoBehaviour 
{
//	public adderV3 _adderV3;
	public Mux _mux;
	public TextMesh tm;
	public int binaryPart;
	
	
	void Start () 
	{
		tm = (TextMesh)GameObject.Find("3rdDigit").GetComponent<TextMesh>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		bool Digit = _mux.ResultIsOn3;
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
