using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Adder : MonoBehaviour 
{

	public GameObject panel1;
	public GameObject panel2;
	public GameObject panelCarry;

	public GameObject wire101;
	public GameObject wire102;
	public GameObject wire103;
	public GameObject wire104;
	public GameObject wire105;
	public GameObject wire106;
	public GameObject wire107;

	public GameObject wire201;
	public GameObject wire202;
	public GameObject wire203;
	public GameObject wire204;
	public GameObject wire205;
	public GameObject wire206;
	public GameObject wire207;
	public GameObject wire208;

	public GameObject wireCarry001;
	public GameObject wireCarry002;
	public GameObject wireCarry003;
	public GameObject wireCarry004;
	public GameObject wireCarry005;
	public GameObject wireCarry006;
	public GameObject wireCarry007;
	public GameObject wireCarry008;
	public GameObject wireCarry009;
	public GameObject wireCarry010;
	public GameObject wireCarry011;
	public GameObject wireCarry012;


	public GameObject Notwire001;
	public GameObject Notwire002;
	public GameObject Notwire003;
	public GameObject Notwire004;
	public GameObject Notwire005;
	public GameObject Notwire006;

	public GameObject intermidiateWire101;
	public GameObject intermidiateWire102;
	public GameObject intermidiateWire201;
	public GameObject intermidiateWire202;
	public GameObject intermidiateWire203;
	public GameObject intermidiateWire301;
	public GameObject intermidiateWire302;
	public GameObject intermidiateWire303;
	public GameObject intermidiateWire401;
	public GameObject intermidiateWire402;

	public GameObject carryWire101;
	public GameObject carryWire102;
	public GameObject carryWire201;
	public GameObject carryWire301;
	public GameObject carryWire302;
	
	public GameObject resultWire;
	public GameObject resultPanel;

	public GameObject CarryResultWire;

	public GameObject A2panel1;
	public GameObject A2panel2;
	public GameObject A2panelCarry;
	
	public GameObject A2wire101;
	public GameObject A2wire102;
	public GameObject A2wire103;
	public GameObject A2wire104;
	public GameObject A2wire105;
	public GameObject A2wire106;
	public GameObject A2wire107;
	
	public GameObject A2wire201;
	public GameObject A2wire202;
	public GameObject A2wire203;
	public GameObject A2wire204;
	public GameObject A2wire205;
	public GameObject A2wire206;
	public GameObject A2wire207;
	public GameObject A2wire208;
	
	public GameObject A2wireCarry001;
	public GameObject A2wireCarry002;
	public GameObject A2wireCarry003;
	public GameObject A2wireCarry004;
	public GameObject A2wireCarry005;
	public GameObject A2wireCarry006;
	public GameObject A2wireCarry007;
	public GameObject A2wireCarry008;
	public GameObject A2wireCarry009;
	public GameObject A2wireCarry010;
	public GameObject A2wireCarry011;
	public GameObject A2wireCarry012;
	
	
	public GameObject A2Notwire001;
	public GameObject A2Notwire002;
	public GameObject A2Notwire003;
	public GameObject A2Notwire004;
	public GameObject A2Notwire005;
	public GameObject A2Notwire006;
	
	public GameObject A2intermidiateWire101;
	public GameObject A2intermidiateWire102;
	public GameObject A2intermidiateWire201;
	public GameObject A2intermidiateWire202;
	public GameObject A2intermidiateWire203;
	public GameObject A2intermidiateWire301;
	public GameObject A2intermidiateWire302;
	public GameObject A2intermidiateWire303;
	public GameObject A2intermidiateWire401;
	public GameObject A2intermidiateWire402;
	
	public GameObject A2carryWire101;
	public GameObject A2carryWire102;
	public GameObject A2carryWire201;
	public GameObject A2carryWire301;
	public GameObject A2carryWire302;
	
	public GameObject A2resultWire;
	public GameObject A2resultPanel;
	
	public GameObject A2CarryResultWire;

	public GameObject A3panel1;
	public GameObject A3panel2;
	public GameObject A3panelCarry;
	
	public GameObject A3wire101;
	public GameObject A3wire102;
	public GameObject A3wire103;
	public GameObject A3wire104;
	public GameObject A3wire105;
	public GameObject A3wire106;
	public GameObject A3wire107;
	
	public GameObject A3wire201;
	public GameObject A3wire202;
	public GameObject A3wire203;
	public GameObject A3wire204;
	public GameObject A3wire205;
	public GameObject A3wire206;
	public GameObject A3wire207;
	public GameObject A3wire208;
	
	public GameObject A3wireCarry001;
	public GameObject A3wireCarry002;
	public GameObject A3wireCarry003;
	public GameObject A3wireCarry004;
	public GameObject A3wireCarry005;
	public GameObject A3wireCarry006;
	public GameObject A3wireCarry007;
	public GameObject A3wireCarry008;
	public GameObject A3wireCarry009;
	public GameObject A3wireCarry010;
	public GameObject A3wireCarry011;
	public GameObject A3wireCarry012;

	
	public GameObject A3Notwire001;
	public GameObject A3Notwire002;
	public GameObject A3Notwire003;
	public GameObject A3Notwire004;
	public GameObject A3Notwire005;
	public GameObject A3Notwire006;
	
	public GameObject A3intermidiateWire101;
	public GameObject A3intermidiateWire102;
	public GameObject A3intermidiateWire201;
	public GameObject A3intermidiateWire202;
	public GameObject A3intermidiateWire203;
	public GameObject A3intermidiateWire301;
	public GameObject A3intermidiateWire302;
	public GameObject A3intermidiateWire303;
	public GameObject A3intermidiateWire401;
	public GameObject A3intermidiateWire402;

	public GameObject A3carryWire101;
	public GameObject A3carryWire102;
	public GameObject A3carryWire201;
	public GameObject A3carryWire301;
	public GameObject A3carryWire302;
	
	public GameObject A3resultWire;
	public GameObject A3resultPanel;
	
	public GameObject A3CarryResultWire;


	public GameObject A4panel1;
	public GameObject A4panel2;
	public GameObject A4panelCarry;
	
	public GameObject A4wire101;
	public GameObject A4wire102;
	public GameObject A4wire103;
	public GameObject A4wire104;
	public GameObject A4wire105;
	public GameObject A4wire106;
	public GameObject A4wire107;
	
	public GameObject A4wire201;
	public GameObject A4wire202;
	public GameObject A4wire203;
	public GameObject A4wire204;
	public GameObject A4wire205;
	public GameObject A4wire206;
	public GameObject A4wire207;
	public GameObject A4wire208;
	
	public GameObject A4wireCarry001;
	public GameObject A4wireCarry002;
	public GameObject A4wireCarry003;
	public GameObject A4wireCarry004;
	public GameObject A4wireCarry005;
	public GameObject A4wireCarry006;
	public GameObject A4wireCarry007;
	public GameObject A4wireCarry008;
	public GameObject A4wireCarry009;
	public GameObject A4wireCarry010;
	public GameObject A4wireCarry011;
	public GameObject A4wireCarry012;

	
	public GameObject A4Notwire001;
	public GameObject A4Notwire002;
	public GameObject A4Notwire003;
	public GameObject A4Notwire004;
	public GameObject A4Notwire005;
	public GameObject A4Notwire006;

	public GameObject A4intermidiateWire101;
	public GameObject A4intermidiateWire102;
	public GameObject A4intermidiateWire201;
	public GameObject A4intermidiateWire202;
	public GameObject A4intermidiateWire203;
	public GameObject A4intermidiateWire301;
	public GameObject A4intermidiateWire302;
	public GameObject A4intermidiateWire303;
	public GameObject A4intermidiateWire401;
	public GameObject A4intermidiateWire402;

	public GameObject A4carryWire101;
	public GameObject A4carryWire102;
	public GameObject A4carryWire201;
	public GameObject A4carryWire301;
	public GameObject A4carryWire302;

	public GameObject A4resultWire;
	public GameObject A4resultPanel;
	
	public GameObject A4CarryResultWire;


	bool panel1IsOn1;
	bool panel2IsOn1;
	bool panelCarryIsOn1;
	bool intermidiateWire001IsOn1;
	bool intermidiateWire002IsOn1;
	bool intermidiateWire003IsOn1;
	bool intermidiateWire004IsOn1;
	bool CarryWire001IsOn1;
	bool CarryWire002IsOn1;
	bool CarryWire003IsOn1;

	bool panel1IsOn2;
	bool panel2IsOn2;
	bool panelCarryIsOn2;
	bool intermidiateWire001IsOn2;
	bool intermidiateWire002IsOn2;
	bool intermidiateWire003IsOn2;
	bool intermidiateWire004IsOn2;
	bool CarryWire001IsOn2;
	bool CarryWire002IsOn2;
	bool CarryWire003IsOn2;
	bool CarryPanelOn2;

	bool panel1IsOn3;
	bool panel2IsOn3;
	bool panelCarryIsOn3;
	bool intermidiateWire001IsOn3;
	bool intermidiateWire002IsOn3;
	bool intermidiateWire003IsOn3;
	bool intermidiateWire004IsOn3;
	bool CarryWire001IsOn3;
	bool CarryWire002IsOn3;
	bool CarryWire003IsOn3;
	bool CarryPanelOn3;

	bool panel1IsOn4;
	bool panel2IsOn4;
	bool panelCarryIsOn4;
	bool intermidiateWire001IsOn4;
	bool intermidiateWire002IsOn4;
	bool intermidiateWire003IsOn4;
	bool intermidiateWire004IsOn4;
	bool CarryWire001IsOn4;
	bool CarryWire002IsOn4;
	bool CarryWire003IsOn4;
	

	// Use this for initialization
	void Start () 
	{
		bools();
	}

	// Update is called once per frame
	void Update () 
	{
		Shortcuts();
		Adder1();
		Adder2();
		Adder3();
		Adder4();

	
	}
	

	void bools()
	{
		panel1IsOn1 = false;
		panel2IsOn1 = false;
		panelCarryIsOn1 = false;
		
		intermidiateWire001IsOn1 = false;
		intermidiateWire002IsOn1 = false;
		intermidiateWire003IsOn1 = false;
		intermidiateWire004IsOn1 = false;
		
		CarryWire001IsOn1 = false;
		CarryWire002IsOn1 = false;
		CarryWire003IsOn1 = false;

		//Adder2
		panel1IsOn2 = false;
		panel2IsOn2 = false;
		panelCarryIsOn2 = false;
		
		intermidiateWire001IsOn2 = false;
		intermidiateWire002IsOn2 = false;
		intermidiateWire003IsOn2 = false;
		intermidiateWire004IsOn2 = false;
		
		CarryWire001IsOn2 = false;
		CarryWire002IsOn2 = false;
		CarryWire003IsOn2 = false;
		CarryPanelOn2 = false;

		//Adder3
		panel1IsOn3 = false;
		panel2IsOn3 = false;
		panelCarryIsOn3 = false;
		
		intermidiateWire001IsOn3 = false;
		intermidiateWire002IsOn3 = false;
		intermidiateWire003IsOn3 = false;
		intermidiateWire004IsOn3 = false;
		
		CarryWire001IsOn3 = false;
		CarryWire002IsOn3 = false;
		CarryWire003IsOn3 = false;
		CarryPanelOn3 = false;

		//Adder4
		panel1IsOn4 = false;
		panel2IsOn4 = false;
		panelCarryIsOn4 = false;
		
		intermidiateWire001IsOn4 = false;
		intermidiateWire002IsOn4 = false;
		intermidiateWire003IsOn4 = false;
		intermidiateWire004IsOn4 = false;
		
		CarryWire001IsOn4 = false;
		CarryWire002IsOn4 = false;
		CarryWire003IsOn4 = false;
	}

	void Shortcuts()
	{
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			if(panel1IsOn1 == false)
			{
				panel1IsOn1 = true;

			}
			else
			{
				panel1IsOn1 = false;
				
			}
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha2))
		   {
			if(panel2IsOn1 == false)
			{
				panel2IsOn1 = true;
				
			}
			else
			{
				panel2IsOn1 = false;
				
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha3))
		   {
			if(panel1IsOn2 == false)
			{
				panel1IsOn2 = true;
				
			}
			else
			{
				panel1IsOn2 = false;
				
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha4))
		{
			if(panel2IsOn2 == false)
			{
				panel2IsOn2 = true;
				
			}
			else
			{
				panel2IsOn2 = false;
				
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha5))
		{
			if(panel1IsOn3 == false)
			{
				panel1IsOn3 = true;
				
			}
			else
			{
				panel1IsOn3 = false;
				
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha6))
		{
			if(panel2IsOn3 == false)
			{
				panel2IsOn3 = true;
				
			}
			else
			{
				panel2IsOn3 = false;
				
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha7))
		{
			if(panel1IsOn4 == false)
			{
				panel1IsOn4 = true;


				
			}
			else
			{
				panel1IsOn4 = false;

				
			}
		}
		if(Input.GetKeyDown(KeyCode.Alpha8))
		{

			if(panel2IsOn4 == false)
			{
				panel2IsOn4 = true;

				
			}
			else
			{
				panel2IsOn4 = false;
				
			}
		}
	}

	void Adder1()
	{

		if(panel1IsOn1 == true)
		{

			panel1.GetComponent<Renderer>().material.color = Color.green;
			
			wire101.GetComponent<Renderer>().material.color = Color.green;
			wire102.GetComponent<Renderer>().material.color = Color.green;
			wire103.GetComponent<Renderer>().material.color = Color.green;
			wire104.GetComponent<Renderer>().material.color = Color.green;
			wire105.GetComponent<Renderer>().material.color = Color.green;
			wire106.GetComponent<Renderer>().material.color = Color.green;
			wire107.GetComponent<Renderer>().material.color = Color.green;
			
			Notwire001.GetComponent<Renderer>().material.color = Color.red;
			Notwire003.GetComponent<Renderer>().material.color = Color.red;
			
		
		}
		else
		{
			panel1.GetComponent<Renderer>().material.color = Color.red;
			
			wire101.GetComponent<Renderer>().material.color = Color.red;
			wire102.GetComponent<Renderer>().material.color = Color.red;
			wire103.GetComponent<Renderer>().material.color = Color.red;
			wire104.GetComponent<Renderer>().material.color = Color.red;
			wire105.GetComponent<Renderer>().material.color = Color.red;
			wire106.GetComponent<Renderer>().material.color = Color.red;
			wire107.GetComponent<Renderer>().material.color = Color.red;
			
			Notwire001.GetComponent<Renderer>().material.color = Color.green;
			Notwire003.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		if(panel2IsOn1 == true)
		{
			panel2.GetComponent<Renderer>().material.color = Color.green;
			
			wire201.GetComponent<Renderer>().material.color = Color.green;
			wire202.GetComponent<Renderer>().material.color = Color.green;
			wire203.GetComponent<Renderer>().material.color = Color.green;
			wire204.GetComponent<Renderer>().material.color = Color.green;
			wire205.GetComponent<Renderer>().material.color = Color.green;
			wire206.GetComponent<Renderer>().material.color = Color.green;
			wire207.GetComponent<Renderer>().material.color = Color.green;
			wire208.GetComponent<Renderer>().material.color = Color.green;
			
			Notwire002.GetComponent<Renderer>().material.color = Color.red;
			Notwire005.GetComponent<Renderer>().material.color = Color.red;
		}
		else
		{
			panel2.GetComponent<Renderer>().material.color = Color.red;
			
			wire201.GetComponent<Renderer>().material.color = Color.red;
			wire202.GetComponent<Renderer>().material.color = Color.red;
			wire203.GetComponent<Renderer>().material.color = Color.red;
			wire204.GetComponent<Renderer>().material.color = Color.red;
			wire205.GetComponent<Renderer>().material.color = Color.red;
			wire206.GetComponent<Renderer>().material.color = Color.red;
			wire207.GetComponent<Renderer>().material.color = Color.red;
			wire208.GetComponent<Renderer>().material.color = Color.red;
			
			Notwire002.GetComponent<Renderer>().material.color = Color.green;
			Notwire005.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		if(panelCarryIsOn1 == true)
		{
			panelCarry.GetComponent<Renderer>().material.color = Color.green;
			
			wireCarry001.GetComponent<Renderer>().material.color = Color.green;
			wireCarry002.GetComponent<Renderer>().material.color = Color.green;
			wireCarry003.GetComponent<Renderer>().material.color = Color.green;
			wireCarry004.GetComponent<Renderer>().material.color = Color.green;
			wireCarry005.GetComponent<Renderer>().material.color = Color.green;
			wireCarry006.GetComponent<Renderer>().material.color = Color.green;
			wireCarry007.GetComponent<Renderer>().material.color = Color.green;
			wireCarry008.GetComponent<Renderer>().material.color = Color.green;
			wireCarry009.GetComponent<Renderer>().material.color = Color.green;
			wireCarry010.GetComponent<Renderer>().material.color = Color.green;
			wireCarry011.GetComponent<Renderer>().material.color = Color.green;
			wireCarry012.GetComponent<Renderer>().material.color = Color.green;
			
			Notwire004.GetComponent<Renderer>().material.color = Color.red;
			Notwire006.GetComponent<Renderer>().material.color = Color.red;
			
		}
		else
		{
			panelCarry.GetComponent<Renderer>().material.color = Color.red;
			
			wireCarry001.GetComponent<Renderer>().material.color = Color.red;
			wireCarry002.GetComponent<Renderer>().material.color = Color.red;
			wireCarry003.GetComponent<Renderer>().material.color = Color.red;
			wireCarry004.GetComponent<Renderer>().material.color = Color.red;
			wireCarry005.GetComponent<Renderer>().material.color = Color.red;
			wireCarry006.GetComponent<Renderer>().material.color = Color.red;
			wireCarry007.GetComponent<Renderer>().material.color = Color.red;
			wireCarry008.GetComponent<Renderer>().material.color = Color.red;
			wireCarry009.GetComponent<Renderer>().material.color = Color.red;
			wireCarry010.GetComponent<Renderer>().material.color = Color.red;
			wireCarry011.GetComponent<Renderer>().material.color = Color.red;
			wireCarry012.GetComponent<Renderer>().material.color = Color.red;
			
			Notwire004.GetComponent<Renderer>().material.color = Color.green;
			Notwire006.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		
		
		if(!panel1IsOn1 && !panel2IsOn1 && panelCarryIsOn1)
		{
			intermidiateWire001IsOn1 = true;
		}
		else
		{
			intermidiateWire001IsOn1 = false;
		}
		
		if(!panel1IsOn1 && panel2IsOn1 && !panelCarryIsOn1)
		{
			intermidiateWire002IsOn1 = true;
		}
		else
		{
			intermidiateWire002IsOn1 = false;
		}
		
		if(panel1IsOn1 && !panel2IsOn1 && !panelCarryIsOn1)
		{
			intermidiateWire003IsOn1 = true;
		}
		else
		{
			intermidiateWire003IsOn1 = false;
		}
		
		if(panel1IsOn1 && panel2IsOn1&& panelCarryIsOn1)
		{
			intermidiateWire004IsOn1 = true;
		}
		else
		{
			intermidiateWire004IsOn1 = false;
		}

		if(panel1IsOn1 && panel2IsOn1)
		{
			CarryWire001IsOn1 = true;
		}
		else
		{
			CarryWire001IsOn1 = false;
		}
		if(panel1IsOn1 && panelCarryIsOn1)
		{
			CarryWire002IsOn1 = true;
		}
		else
		{
			CarryWire002IsOn1 = false;
		}
		if(panel2IsOn1 && panelCarryIsOn1)
		{
			CarryWire003IsOn1 = true;
		}
		else
		{
			CarryWire003IsOn1 = false;
		}
		
		if(intermidiateWire001IsOn1)
		{
			intermidiateWire101.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire102.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			intermidiateWire101.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire102.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(intermidiateWire002IsOn1)
		{
			intermidiateWire201.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire202.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire203.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			intermidiateWire201.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire202.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire203.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire003IsOn1)
		{
			intermidiateWire301.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire302.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire303.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			intermidiateWire301.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire302.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire303.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire004IsOn1)
		{
			intermidiateWire401.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire402.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			intermidiateWire401.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire402.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire001IsOn1 || intermidiateWire002IsOn1 || intermidiateWire003IsOn1 || intermidiateWire004IsOn1)
		{
			resultWire.GetComponent<Renderer>().material.color = Color.green;
			resultPanel.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			resultWire.GetComponent<Renderer>().material.color = Color.red;
			resultPanel.GetComponent<Renderer>().material.color = Color.red;
		}

		if(CarryWire001IsOn1)
		{
			carryWire101.GetComponent<Renderer>().material.color = Color.green;
			carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			carryWire101.GetComponent<Renderer>().material.color = Color.green;
			carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}

		if(CarryWire001IsOn1)
		{
			carryWire101.GetComponent<Renderer>().material.color = Color.green;
			carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			carryWire101.GetComponent<Renderer>().material.color = Color.red;
			carryWire102.GetComponent<Renderer>().material.color = Color.red;
		}

		if(CarryWire002IsOn1)
		{
			carryWire201.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			carryWire201.GetComponent<Renderer>().material.color = Color.red;
		}

		if(CarryWire003IsOn1)
		{
			carryWire301.GetComponent<Renderer>().material.color = Color.green;
			carryWire302.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			carryWire301.GetComponent<Renderer>().material.color = Color.red;
			carryWire302.GetComponent<Renderer>().material.color = Color.red;
		}

		if(CarryWire001IsOn1 || CarryWire002IsOn1 || CarryWire003IsOn1)
		{
			CarryResultWire.GetComponent<Renderer>().material.color = Color.green;
			//panelCarryIsOn2 = true;
			//A2panelCarry.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			CarryResultWire.GetComponent<Renderer>().material.color = Color.red;
			//panelCarryIsOn2 = false;
			//A2panelCarry.GetComponent<Renderer>().material.color = Color.red;

		}


	}

	void Adder2()
	{
		if(panel1IsOn2 == true)
		{
			
			A2panel1.GetComponent<Renderer>().material.color = Color.green;

			A2wire101.GetComponent<Renderer>().material.color = Color.green;
			A2wire102.GetComponent<Renderer>().material.color = Color.green;
			A2wire103.GetComponent<Renderer>().material.color = Color.green;
			A2wire104.GetComponent<Renderer>().material.color = Color.green;
			A2wire105.GetComponent<Renderer>().material.color = Color.green;
			A2wire106.GetComponent<Renderer>().material.color = Color.green;
			A2wire107.GetComponent<Renderer>().material.color = Color.green;
			
			A2Notwire001.GetComponent<Renderer>().material.color = Color.red;
			A2Notwire003.GetComponent<Renderer>().material.color = Color.red;
			
			
		}
		else
		{
			A2panel1.GetComponent<Renderer>().material.color = Color.red;
			
			A2wire101.GetComponent<Renderer>().material.color = Color.red;
			A2wire102.GetComponent<Renderer>().material.color = Color.red;
			A2wire103.GetComponent<Renderer>().material.color = Color.red;
			A2wire104.GetComponent<Renderer>().material.color = Color.red;
			A2wire105.GetComponent<Renderer>().material.color = Color.red;
			A2wire106.GetComponent<Renderer>().material.color = Color.red;
			A2wire107.GetComponent<Renderer>().material.color = Color.red;
			
			A2Notwire001.GetComponent<Renderer>().material.color = Color.green;
			A2Notwire003.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		if(panel2IsOn2 == true)
		{
			A2panel2.GetComponent<Renderer>().material.color = Color.green;
			
			A2wire201.GetComponent<Renderer>().material.color = Color.green;
			A2wire202.GetComponent<Renderer>().material.color = Color.green;
			A2wire203.GetComponent<Renderer>().material.color = Color.green;
			A2wire204.GetComponent<Renderer>().material.color = Color.green;
			A2wire205.GetComponent<Renderer>().material.color = Color.green;
			A2wire206.GetComponent<Renderer>().material.color = Color.green;
			A2wire207.GetComponent<Renderer>().material.color = Color.green;
			A2wire208.GetComponent<Renderer>().material.color = Color.green;
			
			A2Notwire002.GetComponent<Renderer>().material.color = Color.red;
			A2Notwire005.GetComponent<Renderer>().material.color = Color.red;
		}
		else
		{
			A2panel2.GetComponent<Renderer>().material.color = Color.red;
			
			A2wire201.GetComponent<Renderer>().material.color = Color.red;
			A2wire202.GetComponent<Renderer>().material.color = Color.red;
			A2wire203.GetComponent<Renderer>().material.color = Color.red;
			A2wire204.GetComponent<Renderer>().material.color = Color.red;
			A2wire205.GetComponent<Renderer>().material.color = Color.red;
			A2wire206.GetComponent<Renderer>().material.color = Color.red;
			A2wire207.GetComponent<Renderer>().material.color = Color.red;
			A2wire208.GetComponent<Renderer>().material.color = Color.red;
			
			A2Notwire002.GetComponent<Renderer>().material.color = Color.green;
			A2Notwire005.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		if(panelCarryIsOn2 == true)
		{
			A2panelCarry.GetComponent<Renderer>().material.color = Color.green;
			
			A2wireCarry001.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry002.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry003.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry004.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry005.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry006.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry007.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry008.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry009.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry010.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry011.GetComponent<Renderer>().material.color = Color.green;
			A2wireCarry012.GetComponent<Renderer>().material.color = Color.green;
			
			A2Notwire004.GetComponent<Renderer>().material.color = Color.red;
			A2Notwire006.GetComponent<Renderer>().material.color = Color.red;
			
		}
		else
		{
			A2panelCarry.GetComponent<Renderer>().material.color = Color.red;
			
			A2wireCarry001.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry002.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry003.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry004.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry005.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry006.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry007.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry008.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry009.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry010.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry011.GetComponent<Renderer>().material.color = Color.red;
			A2wireCarry012.GetComponent<Renderer>().material.color = Color.red;
			
			A2Notwire004.GetComponent<Renderer>().material.color = Color.green;
			A2Notwire006.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		
		
		if(!panel1IsOn2 && !panel2IsOn2 && panelCarryIsOn2)
		{
			intermidiateWire001IsOn2 = true;
		}
		else
		{
			intermidiateWire001IsOn2 = false;
		}
		
		if(!panel1IsOn2 && panel2IsOn2 && !panelCarryIsOn2)
		{
			intermidiateWire002IsOn2 = true;
		}
		else
		{
			intermidiateWire002IsOn2 = false;
		}
		
		if(panel1IsOn2 && !panel2IsOn2 && !panelCarryIsOn2)
		{
			intermidiateWire003IsOn2 = true;
		}
		else
		{
			intermidiateWire003IsOn2 = false;
		}
		
		if(panel1IsOn2 && panel2IsOn2 && panelCarryIsOn2)
		{
			intermidiateWire004IsOn2 = true;
		}
		else
		{
			intermidiateWire004IsOn2 = false;
		}
		
		if(panel1IsOn2 && panel2IsOn2)
		{
			CarryWire001IsOn2 = true;
		}
		else
		{
			CarryWire001IsOn2 = false;
		}
		if(panel1IsOn2 && panelCarryIsOn2)
		{
			CarryWire002IsOn2 = true;
		}
		else
		{
			CarryWire002IsOn2 = false;
		}
		if(panel2IsOn2 && panelCarryIsOn2)
		{
			CarryWire003IsOn2 = true;
		}
		else
		{
			CarryWire003IsOn2 = false;
		}
		
		if(intermidiateWire001IsOn2)
		{
			A2intermidiateWire101.GetComponent<Renderer>().material.color = Color.green;
			A2intermidiateWire102.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A2intermidiateWire101.GetComponent<Renderer>().material.color = Color.red;
			A2intermidiateWire102.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(intermidiateWire002IsOn2)
		{
			A2intermidiateWire201.GetComponent<Renderer>().material.color = Color.green;
			A2intermidiateWire202.GetComponent<Renderer>().material.color = Color.green;
			A2intermidiateWire203.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A2intermidiateWire201.GetComponent<Renderer>().material.color = Color.red;
			A2intermidiateWire202.GetComponent<Renderer>().material.color = Color.red;
			A2intermidiateWire203.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire003IsOn2)
		{
			A2intermidiateWire301.GetComponent<Renderer>().material.color = Color.green;
			A2intermidiateWire302.GetComponent<Renderer>().material.color = Color.green;
			A2intermidiateWire303.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A2intermidiateWire301.GetComponent<Renderer>().material.color = Color.red;
			A2intermidiateWire302.GetComponent<Renderer>().material.color = Color.red;
			A2intermidiateWire303.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire004IsOn2)
		{
			A2intermidiateWire401.GetComponent<Renderer>().material.color = Color.green;
			A2intermidiateWire402.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A2intermidiateWire401.GetComponent<Renderer>().material.color = Color.red;
			A2intermidiateWire402.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire001IsOn2 || intermidiateWire002IsOn2 || intermidiateWire003IsOn2 || intermidiateWire004IsOn2)
		{
			A2resultWire.GetComponent<Renderer>().material.color = Color.green;
			A2resultPanel.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A2resultWire.GetComponent<Renderer>().material.color = Color.red;
			A2resultPanel.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire001IsOn2)
		{
			A2carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A2carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A2carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A2carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		
		if(CarryWire001IsOn2)
		{
			A2carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A2carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A2carryWire101.GetComponent<Renderer>().material.color = Color.red;
			A2carryWire102.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire002IsOn2)
		{
			A2carryWire201.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A2carryWire201.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire003IsOn2)
		{
			A2carryWire301.GetComponent<Renderer>().material.color = Color.green;
			A2carryWire302.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A2carryWire301.GetComponent<Renderer>().material.color = Color.red;
			A2carryWire302.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire001IsOn2 || CarryWire002IsOn2 || CarryWire003IsOn2)
		{
			A2CarryResultWire.GetComponent<Renderer>().material.color = Color.green;
			panelCarryIsOn3 = true;
			A3panelCarry.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A2CarryResultWire.GetComponent<Renderer>().material.color = Color.red;
			panelCarryIsOn3 = false;
			A3panelCarry.GetComponent<Renderer>().material.color = Color.red;
		}
	}

	void Adder3()
	{
		if(panel1IsOn3 == true)
		{
			
			A3panel1.GetComponent<Renderer>().material.color = Color.green;
			
			A3wire101.GetComponent<Renderer>().material.color = Color.green;
			A3wire102.GetComponent<Renderer>().material.color = Color.green;
			A3wire103.GetComponent<Renderer>().material.color = Color.green;
			A3wire104.GetComponent<Renderer>().material.color = Color.green;
			A3wire105.GetComponent<Renderer>().material.color = Color.green;
			A3wire106.GetComponent<Renderer>().material.color = Color.green;
			A3wire107.GetComponent<Renderer>().material.color = Color.green;
			
			A3Notwire001.GetComponent<Renderer>().material.color = Color.red;
			A3Notwire003.GetComponent<Renderer>().material.color = Color.red;
			
			
		}
		else
		{
			A3panel1.GetComponent<Renderer>().material.color = Color.red;
		
			A3wire101.GetComponent<Renderer>().material.color = Color.red;
			A3wire102.GetComponent<Renderer>().material.color = Color.red;
			A3wire103.GetComponent<Renderer>().material.color = Color.red;
			A3wire104.GetComponent<Renderer>().material.color = Color.red;
			A3wire105.GetComponent<Renderer>().material.color = Color.red;
			A3wire106.GetComponent<Renderer>().material.color = Color.red;
			A3wire107.GetComponent<Renderer>().material.color = Color.red;
		
			A3Notwire001.GetComponent<Renderer>().material.color = Color.green;
			A3Notwire003.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		if(panel2IsOn3 == true)
		{
			A3panel2.GetComponent<Renderer>().material.color = Color.green;
			
			A3wire201.GetComponent<Renderer>().material.color = Color.green;
			A3wire202.GetComponent<Renderer>().material.color = Color.green;
			A3wire203.GetComponent<Renderer>().material.color = Color.green;
			A3wire204.GetComponent<Renderer>().material.color = Color.green;
			A3wire205.GetComponent<Renderer>().material.color = Color.green;
			A3wire206.GetComponent<Renderer>().material.color = Color.green;
			A3wire207.GetComponent<Renderer>().material.color = Color.green;
			A3wire208.GetComponent<Renderer>().material.color = Color.green;
			
			A3Notwire002.GetComponent<Renderer>().material.color = Color.red;
			A3Notwire005.GetComponent<Renderer>().material.color = Color.red;
		}
		else
		{
			A3panel2.GetComponent<Renderer>().material.color = Color.red;
			
			A3wire201.GetComponent<Renderer>().material.color = Color.red;
			A3wire202.GetComponent<Renderer>().material.color = Color.red;
			A3wire203.GetComponent<Renderer>().material.color = Color.red;
			A3wire204.GetComponent<Renderer>().material.color = Color.red;
			A3wire205.GetComponent<Renderer>().material.color = Color.red;
			A3wire206.GetComponent<Renderer>().material.color = Color.red;
			A3wire207.GetComponent<Renderer>().material.color = Color.red;
			A3wire208.GetComponent<Renderer>().material.color = Color.red;
			
			A3Notwire002.GetComponent<Renderer>().material.color = Color.green;
			A3Notwire005.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		if(panelCarryIsOn3 == true)
		{
			A3panelCarry.GetComponent<Renderer>().material.color = Color.green;
			
			A3wireCarry001.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry002.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry003.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry004.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry005.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry006.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry007.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry008.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry009.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry010.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry011.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry012.GetComponent<Renderer>().material.color = Color.green;
			
			A3Notwire004.GetComponent<Renderer>().material.color = Color.red;
			A3Notwire006.GetComponent<Renderer>().material.color = Color.red;
		
		}
		else
		{
			A3panelCarry.GetComponent<Renderer>().material.color = Color.red;
			
			A3wireCarry001.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry002.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry003.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry004.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry005.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry006.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry007.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry008.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry009.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry010.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry011.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry012.GetComponent<Renderer>().material.color = Color.red;
		
			A3Notwire004.GetComponent<Renderer>().material.color = Color.green;
			A3Notwire006.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		
		
		if(!panel1IsOn3 && !panel2IsOn3 && panelCarryIsOn3)
		{
			intermidiateWire001IsOn3 = true;
		}
		else
		{
			intermidiateWire001IsOn3 = false;
		}
		
		if(!panel1IsOn3 && panel2IsOn3 && !panelCarryIsOn3)
		{
			intermidiateWire002IsOn3 = true;
		}
		else
		{
			intermidiateWire002IsOn3 = false;
		}
		
		if(panel1IsOn3 && !panel2IsOn3 && !panelCarryIsOn3)
		{
			intermidiateWire003IsOn3 = true;
		}
		else
		{
			intermidiateWire003IsOn3 = false;
		}
		
		if(panel1IsOn3 && panel2IsOn3 && panelCarryIsOn3)
		{
			intermidiateWire004IsOn3 = true;
		}
		else
		{
			intermidiateWire004IsOn3 = false;
		}
		
		if(panel1IsOn3 && panel2IsOn3)
		{
			CarryWire001IsOn3 = true;
		}
		else
		{
			CarryWire001IsOn3 = false;
		}
		if(panel1IsOn3 && panelCarryIsOn3)
		{
			CarryWire002IsOn3 = true;
		}
		else
		{
			CarryWire002IsOn3 = false;
		}
		if(panel2IsOn3 && panelCarryIsOn3)
		{
			CarryWire003IsOn3 = true;
		}
		else
		{
			CarryWire003IsOn3 = false;
		}
		
		if(intermidiateWire001IsOn3)
		{
			A3intermidiateWire101.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire102.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A3intermidiateWire101.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire102.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(intermidiateWire002IsOn3)
		{
			A3intermidiateWire201.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire202.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire203.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A3intermidiateWire201.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire202.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire203.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire003IsOn3)
		{
			A3intermidiateWire301.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire302.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire303.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A3intermidiateWire301.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire302.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire303.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire004IsOn3)
		{
			A3intermidiateWire401.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire402.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3intermidiateWire401.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire402.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire001IsOn3 || intermidiateWire002IsOn3 || intermidiateWire003IsOn3 || intermidiateWire004IsOn3)
		{
			A3resultWire.GetComponent<Renderer>().material.color = Color.green;
			A3resultPanel.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3resultWire.GetComponent<Renderer>().material.color = Color.red;
			A3resultPanel.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire001IsOn3)
		{
			A3carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A3carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A3carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		
		if(CarryWire001IsOn3)
		{
			A3carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A3carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3carryWire101.GetComponent<Renderer>().material.color = Color.red;
			A3carryWire102.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire002IsOn3)
		{
			A3carryWire201.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3carryWire201.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire003IsOn3)
		{
			A3carryWire301.GetComponent<Renderer>().material.color = Color.green;
			A3carryWire302.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3carryWire301.GetComponent<Renderer>().material.color = Color.red;
			A3carryWire302.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire001IsOn3 || CarryWire002IsOn3 || CarryWire003IsOn3)
		{
			A3CarryResultWire.GetComponent<Renderer>().material.color = Color.green;

			panelCarryIsOn4 = true;
			A4panelCarry.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A3CarryResultWire.GetComponent<Renderer>().material.color = Color.red;

			panelCarryIsOn4 = false;
			A4panelCarry.GetComponent<Renderer>().material.color = Color.red;
		}
	}

	void Adder4()
	{
		if(panel1IsOn4 == true)
		{
			
			A4panel1.GetComponent<Renderer>().material.color = Color.green;
			
			A4wire101.GetComponent<Renderer>().material.color = Color.green;
			A4wire102.GetComponent<Renderer>().material.color = Color.green;
			A4wire103.GetComponent<Renderer>().material.color = Color.green;
			A4wire104.GetComponent<Renderer>().material.color = Color.green;
			A4wire105.GetComponent<Renderer>().material.color = Color.green;
			A4wire106.GetComponent<Renderer>().material.color = Color.green;
			A4wire107.GetComponent<Renderer>().material.color = Color.green;
			
			A4Notwire001.GetComponent<Renderer>().material.color = Color.red;
			A4Notwire003.GetComponent<Renderer>().material.color = Color.red;
			
			
		}
		else
		{
			A4panel1.GetComponent<Renderer>().material.color = Color.red;
			
			A4wire101.GetComponent<Renderer>().material.color = Color.red;
			A4wire102.GetComponent<Renderer>().material.color = Color.red;
			A4wire103.GetComponent<Renderer>().material.color = Color.red;
			A4wire104.GetComponent<Renderer>().material.color = Color.red;
			A4wire105.GetComponent<Renderer>().material.color = Color.red;
			A4wire106.GetComponent<Renderer>().material.color = Color.red;
			A4wire107.GetComponent<Renderer>().material.color = Color.red;
			
			A4Notwire001.GetComponent<Renderer>().material.color = Color.green;
			A4Notwire003.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		if(panel2IsOn3 == true)
		{
			A3panel2.GetComponent<Renderer>().material.color = Color.green;
			
			A3wire201.GetComponent<Renderer>().material.color = Color.green;
			A3wire202.GetComponent<Renderer>().material.color = Color.green;
			A3wire203.GetComponent<Renderer>().material.color = Color.green;
			A3wire204.GetComponent<Renderer>().material.color = Color.green;
			A3wire205.GetComponent<Renderer>().material.color = Color.green;
			A3wire206.GetComponent<Renderer>().material.color = Color.green;
			A3wire207.GetComponent<Renderer>().material.color = Color.green;
			A3wire208.GetComponent<Renderer>().material.color = Color.green;
			
			A3Notwire002.GetComponent<Renderer>().material.color = Color.red;
			A3Notwire005.GetComponent<Renderer>().material.color = Color.red;
		}
		else
		{
			A3panel2.GetComponent<Renderer>().material.color = Color.red;
			
			A3wire201.GetComponent<Renderer>().material.color = Color.red;
			A3wire202.GetComponent<Renderer>().material.color = Color.red;
			A3wire203.GetComponent<Renderer>().material.color = Color.red;
			A3wire204.GetComponent<Renderer>().material.color = Color.red;
			A3wire205.GetComponent<Renderer>().material.color = Color.red;
			A3wire206.GetComponent<Renderer>().material.color = Color.red;
			A3wire207.GetComponent<Renderer>().material.color = Color.red;
			A3wire208.GetComponent<Renderer>().material.color = Color.red;
			
			A3Notwire002.GetComponent<Renderer>().material.color = Color.green;
			A3Notwire005.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		if(panelCarryIsOn3 == true)
		{
			A3panelCarry.GetComponent<Renderer>().material.color = Color.green;
			
			A3wireCarry001.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry002.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry003.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry004.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry005.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry006.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry007.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry008.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry009.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry010.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry011.GetComponent<Renderer>().material.color = Color.green;
			A3wireCarry012.GetComponent<Renderer>().material.color = Color.green;
			
			A3Notwire004.GetComponent<Renderer>().material.color = Color.red;
			A3Notwire006.GetComponent<Renderer>().material.color = Color.red;
			
		}
		else
		{
			A3panelCarry.GetComponent<Renderer>().material.color = Color.red;
			
			A3wireCarry001.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry002.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry003.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry004.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry005.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry006.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry007.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry008.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry009.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry010.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry011.GetComponent<Renderer>().material.color = Color.red;
			A3wireCarry012.GetComponent<Renderer>().material.color = Color.red;
			
			A3Notwire004.GetComponent<Renderer>().material.color = Color.green;
			A3Notwire006.GetComponent<Renderer>().material.color = Color.green;
			
		}
		
		
		
		if(!panel1IsOn3 && !panel2IsOn3 && panelCarryIsOn3)
		{
			intermidiateWire001IsOn3 = true;
		}
		else
		{
			intermidiateWire001IsOn3 = false;
		}
		
		if(!panel1IsOn3 && panel2IsOn3 && !panelCarryIsOn3)
		{
			intermidiateWire002IsOn3 = true;
		}
		else
		{
			intermidiateWire002IsOn3 = false;
		}
		
		if(panel1IsOn3 && !panel2IsOn3 && !panelCarryIsOn3)
		{
			intermidiateWire003IsOn3 = true;
		}
		else
		{
			intermidiateWire003IsOn3 = false;
		}
		
		if(panel1IsOn3 && panel2IsOn3 && panelCarryIsOn3)
		{
			intermidiateWire004IsOn3 = true;
		}
		else
		{
			intermidiateWire004IsOn3 = false;
		}
		
		if(panel1IsOn3 && panel2IsOn3)
		{
			CarryWire001IsOn3 = true;
		}
		else
		{
			CarryWire001IsOn3 = false;
		}
		if(panel1IsOn3 && panelCarryIsOn3)
		{
			CarryWire002IsOn3 = true;
		}
		else
		{
			CarryWire002IsOn3 = false;
		}
		if(panel2IsOn3 && panelCarryIsOn3)
		{
			CarryWire003IsOn3 = true;
		}
		else
		{
			CarryWire003IsOn3 = false;
		}
		
		if(intermidiateWire001IsOn3)
		{
			A3intermidiateWire101.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire102.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A3intermidiateWire101.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire102.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(intermidiateWire002IsOn3)
		{
			A3intermidiateWire201.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire202.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire203.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A3intermidiateWire201.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire202.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire203.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire003IsOn3)
		{
			A3intermidiateWire301.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire302.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire303.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A3intermidiateWire301.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire302.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire303.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire004IsOn3)
		{
			A3intermidiateWire401.GetComponent<Renderer>().material.color = Color.green;
			A3intermidiateWire402.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3intermidiateWire401.GetComponent<Renderer>().material.color = Color.red;
			A3intermidiateWire402.GetComponent<Renderer>().material.color = Color.red;
			
		}
		
		if(intermidiateWire001IsOn3 || intermidiateWire002IsOn3 || intermidiateWire003IsOn3 || intermidiateWire004IsOn3)
		{
			A3resultWire.GetComponent<Renderer>().material.color = Color.green;
			A3resultPanel.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3resultWire.GetComponent<Renderer>().material.color = Color.red;
			A3resultPanel.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire001IsOn3)
		{
			A3carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A3carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A3carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		
		if(CarryWire001IsOn3)
		{
			A3carryWire101.GetComponent<Renderer>().material.color = Color.green;
			A3carryWire102.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3carryWire101.GetComponent<Renderer>().material.color = Color.red;
			A3carryWire102.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire002IsOn3)
		{
			A3carryWire201.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3carryWire201.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire003IsOn3)
		{
			A3carryWire301.GetComponent<Renderer>().material.color = Color.green;
			A3carryWire302.GetComponent<Renderer>().material.color = Color.green;
		}
		else
		{
			A3carryWire301.GetComponent<Renderer>().material.color = Color.red;
			A3carryWire302.GetComponent<Renderer>().material.color = Color.red;
		}
		
		if(CarryWire001IsOn3 || CarryWire002IsOn3 || CarryWire003IsOn3)
		{
			A3CarryResultWire.GetComponent<Renderer>().material.color = Color.green;
			
			panelCarryIsOn4 = true;
			A4panelCarry.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			A3CarryResultWire.GetComponent<Renderer>().material.color = Color.red;
			
			panelCarryIsOn4 = false;
			A4panelCarry.GetComponent<Renderer>().material.color = Color.red;
		}
	}

	

}
