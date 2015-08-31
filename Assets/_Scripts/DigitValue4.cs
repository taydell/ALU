using UnityEngine;
using System.Collections;

public class DigitValue4 : MonoBehaviour 
{
//	public adderV4 _adderV4;
	public Mux _mux;
	public TextMesh tm;
	public int binaryPart;
	
	void Start () 
	{
		tm = (TextMesh)GameObject.Find("4thDigit").GetComponent<TextMesh>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		bool Digit = _mux.ResultIsOn4;
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
