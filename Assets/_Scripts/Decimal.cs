using UnityEngine;
using System.Collections;
using System;

public class Decimal : MonoBehaviour 
{
	public DigitValue DigitValue;
	public DigitValue2 DigitValue1;
	public DigitValue3 DigitValue2;
	public DigitValue4 DigitValue3;
	public TextMesh tm;

	// Use this for initialization
	void Start () 
	{
		tm = (TextMesh)GameObject.Find("Decimal").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		getBinary();
	}

	void getBinary()
	{
		int value1 = DigitValue.binaryPart;
		int value2 = DigitValue1.binaryPart;
		int value3 = DigitValue2.binaryPart;
		int value4 = DigitValue3.binaryPart;

		string v1 = value1.ToString();
		string v2 = value2.ToString();
		string v3 = value3.ToString();
		string v4 = value4.ToString();

		string number = v4+v3+v2+v1;
		int myInt = Convert.ToInt32(number,2);

		string Digit = myInt.ToString();
	

		tm.text = Digit; 






	}
}
