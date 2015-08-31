using UnityEngine;
using System.Collections;

public class DigitValue : MonoBehaviour {
	//public adderV1 _adderV1;
	public Mux _mux;
	public TextMesh tm;
	public int binaryPart;



	void Start () 
	{
		tm = (TextMesh)GameObject.Find("1stDigit").GetComponent<TextMesh>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		bool Digit = _mux.ResultIsOn;
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
