using UnityEngine;
using System.Collections;



public class adderv2 : MonoBehaviour {

//	public adderV1 _adderV1;
//
//	public GameObject panel1;
//	public GameObject panel2;
//	public GameObject panelCarry;
//	
//	public GameObject wire101;
//	public GameObject wire102;
//	public GameObject wire103;
//	public GameObject wire104;
//	public GameObject wire105;
//	public GameObject wire106;
//	public GameObject wire107;
//	
//	public GameObject wire201;
//	public GameObject wire202;
//	public GameObject wire203;
//	public GameObject wire204;
//	public GameObject wire205;
//	public GameObject wire206;
//	public GameObject wire207;
//	public GameObject wire208;
//	
//	public GameObject wireCarry001;
//	public GameObject wireCarry002;
//	public GameObject wireCarry003;
//	public GameObject wireCarry004;
//	public GameObject wireCarry005;
//	public GameObject wireCarry006;
//	public GameObject wireCarry007;
//	public GameObject wireCarry008;
//	public GameObject wireCarry009;
//	public GameObject wireCarry010;
//	public GameObject wireCarry011;
//	public GameObject wireCarry012;
//	
//	
//	public GameObject Notwire001;
//	public GameObject Notwire002;
//	public GameObject Notwire003;
//	public GameObject Notwire004;
//	public GameObject Notwire005;
//	public GameObject Notwire006;
//	
//	public GameObject intermidiateWire101;
//	public GameObject intermidiateWire102;
//	public GameObject intermidiateWire201;
//	public GameObject intermidiateWire202;
//	public GameObject intermidiateWire203;
//	public GameObject intermidiateWire301;
//	public GameObject intermidiateWire302;
//	public GameObject intermidiateWire303;
//	public GameObject intermidiateWire401;
//	public GameObject intermidiateWire402;
//	
//	public GameObject carryWire101;
//	public GameObject carryWire102;
//	public GameObject carryWire201;
//	public GameObject carryWire301;
//	public GameObject carryWire302;
//	
//	public GameObject resultWire;
//	public GameObject resultPanel;
//	
//	public GameObject CarryResultWire;
//	
//	bool panel1IsOn1;
//	bool panel2IsOn1;
//	bool panelCarryIsOn1;
//
//
//
//	bool intermidiateWire001IsOn1;
//	bool intermidiateWire002IsOn1;
//	bool intermidiateWire003IsOn1;
//	bool intermidiateWire004IsOn1;
//	bool CarryWire001IsOn1;
//	bool CarryWire002IsOn1;
//	bool CarryWire003IsOn1;
//
//	private bool carryResultWireIsOn;
//	
//	public bool CarryResultWireIsOn 
//	{
//		get 
//		{
//			return carryResultWireIsOn;
//		}
//		set 
//		{
//			carryResultWireIsOn = value;
//		}
//	}
//	private bool resultPanelIsOn;
//	
//	public bool ResultPanelIsOn 
//	{
//		get 
//		{
//			return resultPanelIsOn;
//		}
//		set 
//		{
//			resultPanelIsOn = value;
//		}
//	}
//	
//
//
//
//	
//	
//	// Use this for initialization
//	void Start () 
//	{
//		bools();
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//		Shortcuts();
//		Adder1();
//
//
//	}
//	
//	
//	void bools()
//	{
//		panel1IsOn1 = false;
//		panel2IsOn1 = false;
//		panelCarryIsOn1 = false;
//		
//		intermidiateWire001IsOn1 = false;
//		intermidiateWire002IsOn1 = false;
//		intermidiateWire003IsOn1 = false;
//		intermidiateWire004IsOn1 = false;
//		
//		CarryWire001IsOn1 = false;
//		CarryWire002IsOn1 = false;
//		CarryWire003IsOn1 = false;
//
//		resultPanelIsOn = false;
//
//
//
//
//	}
//	
//	void Shortcuts()
//	{
//		if(Input.GetKeyDown(KeyCode.Alpha3))
//		{
//			if(panel1IsOn1 == false)
//			{
//				panel1IsOn1 = true;
//				
//			}
//			else
//			{
//				panel1IsOn1 = false;
//			}
//		}
//		
//		if(Input.GetKeyDown(KeyCode.Alpha4))
//		{
//			if(panel2IsOn1 == false)
//			{
//				panel2IsOn1 = true;
//				
//			}
//			else
//			{
//				panel2IsOn1 = false;
//				
//			}
//		}
//	}
//	
//	void Adder1()
//	{
//		bool on = _adderV1.CarryResultWireIsOn;
//		if(on == true)
//		{
//			panelCarryIsOn1 = true;
//		}
//		else
//		{
//			panelCarryIsOn1 = false;
//		}
//		if(panel1IsOn1 == true)
//		{
//			
//			panel1.GetComponent<Renderer>().material.color = Color.green;
//			
//			wire101.GetComponent<Renderer>().material.color = Color.green;
//			wire102.GetComponent<Renderer>().material.color = Color.green;
//			wire103.GetComponent<Renderer>().material.color = Color.green;
//			wire104.GetComponent<Renderer>().material.color = Color.green;
//			wire105.GetComponent<Renderer>().material.color = Color.green;
//			wire106.GetComponent<Renderer>().material.color = Color.green;
//			wire107.GetComponent<Renderer>().material.color = Color.green;
//			
//			Notwire001.GetComponent<Renderer>().material.color = Color.red;
//			Notwire003.GetComponent<Renderer>().material.color = Color.red;
//			
//			
//		}
//		else
//		{
//			panel1.GetComponent<Renderer>().material.color = Color.red;
//			
//			wire101.GetComponent<Renderer>().material.color = Color.red;
//			wire102.GetComponent<Renderer>().material.color = Color.red;
//			wire103.GetComponent<Renderer>().material.color = Color.red;
//			wire104.GetComponent<Renderer>().material.color = Color.red;
//			wire105.GetComponent<Renderer>().material.color = Color.red;
//			wire106.GetComponent<Renderer>().material.color = Color.red;
//			wire107.GetComponent<Renderer>().material.color = Color.red;
//			
//			Notwire001.GetComponent<Renderer>().material.color = Color.green;
//			Notwire003.GetComponent<Renderer>().material.color = Color.green;
//			
//		}
//		
//		if(panel2IsOn1 == true)
//		{
//			panel2.GetComponent<Renderer>().material.color = Color.green;
//			
//			wire201.GetComponent<Renderer>().material.color = Color.green;
//			wire202.GetComponent<Renderer>().material.color = Color.green;
//			wire203.GetComponent<Renderer>().material.color = Color.green;
//			wire204.GetComponent<Renderer>().material.color = Color.green;
//			wire205.GetComponent<Renderer>().material.color = Color.green;
//			wire206.GetComponent<Renderer>().material.color = Color.green;
//			wire207.GetComponent<Renderer>().material.color = Color.green;
//			wire208.GetComponent<Renderer>().material.color = Color.green;
//			
//			Notwire002.GetComponent<Renderer>().material.color = Color.red;
//			Notwire005.GetComponent<Renderer>().material.color = Color.red;
//		}
//		else
//		{
//			panel2.GetComponent<Renderer>().material.color = Color.red;
//			
//			wire201.GetComponent<Renderer>().material.color = Color.red;
//			wire202.GetComponent<Renderer>().material.color = Color.red;
//			wire203.GetComponent<Renderer>().material.color = Color.red;
//			wire204.GetComponent<Renderer>().material.color = Color.red;
//			wire205.GetComponent<Renderer>().material.color = Color.red;
//			wire206.GetComponent<Renderer>().material.color = Color.red;
//			wire207.GetComponent<Renderer>().material.color = Color.red;
//			wire208.GetComponent<Renderer>().material.color = Color.red;
//			
//			Notwire002.GetComponent<Renderer>().material.color = Color.green;
//			Notwire005.GetComponent<Renderer>().material.color = Color.green;
//			
//		}
//		
//		if(panelCarryIsOn1 == true)
//		{
//			panelCarry.GetComponent<Renderer>().material.color = Color.green;
//			
//			wireCarry001.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry002.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry003.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry004.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry005.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry006.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry007.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry008.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry009.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry010.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry011.GetComponent<Renderer>().material.color = Color.green;
//			wireCarry012.GetComponent<Renderer>().material.color = Color.green;
//			
//			Notwire004.GetComponent<Renderer>().material.color = Color.red;
//			Notwire006.GetComponent<Renderer>().material.color = Color.red;
//			
//		}
//		else
//		{
//			panelCarry.GetComponent<Renderer>().material.color = Color.red;
//			
//			wireCarry001.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry002.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry003.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry004.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry005.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry006.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry007.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry008.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry009.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry010.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry011.GetComponent<Renderer>().material.color = Color.red;
//			wireCarry012.GetComponent<Renderer>().material.color = Color.red;
//			
//			Notwire004.GetComponent<Renderer>().material.color = Color.green;
//			Notwire006.GetComponent<Renderer>().material.color = Color.green;
//			
//		}
//		
//		
//		
//		if(!panel1IsOn1 && !panel2IsOn1 && panelCarryIsOn1)
//		{
//			intermidiateWire001IsOn1 = true;
//		}
//		else
//		{
//			intermidiateWire001IsOn1 = false;
//		}
//		
//		if(!panel1IsOn1 && panel2IsOn1 && !panelCarryIsOn1)
//		{
//			intermidiateWire002IsOn1 = true;
//		}
//		else
//		{
//			intermidiateWire002IsOn1 = false;
//		}
//		
//		if(panel1IsOn1 && !panel2IsOn1 && !panelCarryIsOn1)
//		{
//			intermidiateWire003IsOn1 = true;
//		}
//		else
//		{
//			intermidiateWire003IsOn1 = false;
//		}
//		
//		if(panel1IsOn1 && panel2IsOn1&& panelCarryIsOn1)
//		{
//			intermidiateWire004IsOn1 = true;
//		}
//		else
//		{
//			intermidiateWire004IsOn1 = false;
//		}
//		
//		if(panel1IsOn1 && panel2IsOn1)
//		{
//			CarryWire001IsOn1 = true;
//		}
//		else
//		{
//			CarryWire001IsOn1 = false;
//		}
//		if(panel1IsOn1 && panelCarryIsOn1)
//		{
//			CarryWire002IsOn1 = true;
//		}
//		else
//		{
//			CarryWire002IsOn1 = false;
//		}
//		if(panel2IsOn1 && panelCarryIsOn1)
//		{
//			CarryWire003IsOn1 = true;
//		}
//		else
//		{
//			CarryWire003IsOn1 = false;
//		}
//		
//		if(intermidiateWire001IsOn1)
//		{
//			intermidiateWire101.GetComponent<Renderer>().material.color = Color.green;
//			intermidiateWire102.GetComponent<Renderer>().material.color = Color.green;
//			
//		}
//		else
//		{
//			intermidiateWire101.GetComponent<Renderer>().material.color = Color.red;
//			intermidiateWire102.GetComponent<Renderer>().material.color = Color.red;
//		}
//		
//		if(intermidiateWire002IsOn1)
//		{
//			intermidiateWire201.GetComponent<Renderer>().material.color = Color.green;
//			intermidiateWire202.GetComponent<Renderer>().material.color = Color.green;
//			intermidiateWire203.GetComponent<Renderer>().material.color = Color.green;
//			
//		}
//		else
//		{
//			intermidiateWire201.GetComponent<Renderer>().material.color = Color.red;
//			intermidiateWire202.GetComponent<Renderer>().material.color = Color.red;
//			intermidiateWire203.GetComponent<Renderer>().material.color = Color.red;
//			
//		}
//		
//		if(intermidiateWire003IsOn1)
//		{
//			intermidiateWire301.GetComponent<Renderer>().material.color = Color.green;
//			intermidiateWire302.GetComponent<Renderer>().material.color = Color.green;
//			intermidiateWire303.GetComponent<Renderer>().material.color = Color.green;
//			
//		}
//		else
//		{
//			intermidiateWire301.GetComponent<Renderer>().material.color = Color.red;
//			intermidiateWire302.GetComponent<Renderer>().material.color = Color.red;
//			intermidiateWire303.GetComponent<Renderer>().material.color = Color.red;
//			
//		}
//		
//		if(intermidiateWire004IsOn1)
//		{
//			intermidiateWire401.GetComponent<Renderer>().material.color = Color.green;
//			intermidiateWire402.GetComponent<Renderer>().material.color = Color.green;
//		}
//		else
//		{
//			intermidiateWire401.GetComponent<Renderer>().material.color = Color.red;
//			intermidiateWire402.GetComponent<Renderer>().material.color = Color.red;
//			
//		}
//		
//		if(intermidiateWire001IsOn1 || intermidiateWire002IsOn1 || intermidiateWire003IsOn1 || intermidiateWire004IsOn1)
//		{
//			resultWire.GetComponent<Renderer>().material.color = Color.green;
//			resultPanel.GetComponent<Renderer>().material.color = Color.green;
//			resultPanelIsOn = true;
//		}
//		else
//		{
//			resultWire.GetComponent<Renderer>().material.color = Color.red;
//			resultPanel.GetComponent<Renderer>().material.color = Color.red;
//			resultPanelIsOn = false;
//		}
//		
//		if(CarryWire001IsOn1)
//		{
//			carryWire101.GetComponent<Renderer>().material.color = Color.green;
//			carryWire102.GetComponent<Renderer>().material.color = Color.green;
//		}
//		else
//		{
//			carryWire101.GetComponent<Renderer>().material.color = Color.green;
//			carryWire102.GetComponent<Renderer>().material.color = Color.green;
//		}
//		
//		if(CarryWire001IsOn1)
//		{
//			carryWire101.GetComponent<Renderer>().material.color = Color.green;
//			carryWire102.GetComponent<Renderer>().material.color = Color.green;
//		}
//		else
//		{
//			carryWire101.GetComponent<Renderer>().material.color = Color.red;
//			carryWire102.GetComponent<Renderer>().material.color = Color.red;
//		}
//		
//		if(CarryWire002IsOn1)
//		{
//			carryWire201.GetComponent<Renderer>().material.color = Color.green;
//		}
//		else
//		{
//			carryWire201.GetComponent<Renderer>().material.color = Color.red;
//		}
//		
//		if(CarryWire003IsOn1)
//		{
//			carryWire301.GetComponent<Renderer>().material.color = Color.green;
//			carryWire302.GetComponent<Renderer>().material.color = Color.green;
//		}
//		else
//		{
//			carryWire301.GetComponent<Renderer>().material.color = Color.red;
//			carryWire302.GetComponent<Renderer>().material.color = Color.red;
//		}
//		
//		if(CarryWire001IsOn1 || CarryWire002IsOn1 || CarryWire003IsOn1)
//		{
//			CarryResultWire.GetComponent<Renderer>().material.color = Color.green;
//			carryResultWireIsOn = true;
//
//		}
//		else
//		{
//			CarryResultWire.GetComponent<Renderer>().material.color = Color.red;
//			carryResultWireIsOn = false;
//
//			
//		}
//		
//	}

	public Mux _mux;
	public adderV1 _adderV1;
	
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
	public GameObject wire108;
	public GameObject wire109;
	
	public GameObject XOrWire001;
	public GameObject wire201;
	public GameObject wire202;
	public GameObject wire203;
	public GameObject wire204;
	public GameObject wire205;
	public GameObject wire206;
	public GameObject wire207;
	public GameObject wire208;
	public GameObject wire209;
	public GameObject wire210;
	
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
	public GameObject intermidiateWire501;
	public GameObject intermidiateWire502;
	public GameObject intermidiateWire503;
	public GameObject intermidiateWire601;
	public GameObject intermidiateWire602;
	public GameObject intermidiateWire603;
	
	
	public GameObject carryWire101;
	public GameObject carryWire102;
	public GameObject carryWire201;
	public GameObject carryWire301;
	public GameObject carryWire302;
	
	public GameObject resultWire;
	public GameObject resultWire002;
	public GameObject resultWireSum;
	public GameObject resultWireSub;
	public GameObject resultPanel;
	
	public GameObject CarryResultWire;
	
	public GameObject MuxAndpanel;
	public GameObject MuxOrPanel;
	public GameObject MuxSubPanel;
	
	bool panel1IsOn1;
	bool panel2IsOn1;
	bool panelCarryIsOn1;
	bool XOrWireIsOn;
	bool intermidiateWire001IsOn1;
	bool intermidiateWire002IsOn1;
	bool intermidiateWire003IsOn1;
	bool intermidiateWire004IsOn1;
	bool intermidiateWire005IsOn1;
	
	public bool IntermidiateWire005IsOn1 {
		get {
			return intermidiateWire005IsOn1;
		}
		set {
			intermidiateWire005IsOn1 = value;
		}
	}
	
	bool intermidiateWire006IsOn1;
	
	public bool IntermidiateWire006IsOn1 {
		get {
			return intermidiateWire006IsOn1;
		}
		set {
			intermidiateWire006IsOn1 = value;
		}
	}
	
	bool CarryWire001IsOn1;
	bool CarryWire002IsOn1;
	bool CarryWire003IsOn1;
	
	
	
	private bool carryResultWireIsOn;
	
	public bool CarryResultWireIsOn 
	{
		get 
		{
			return carryResultWireIsOn;
		}
		set 
		{
			carryResultWireIsOn = value;
		}
	}
	private bool resultPanelIsOn;
	
	public bool ResultPanelIsOn {
		get {
			return resultPanelIsOn;
		}
		set {
			resultPanelIsOn = value;
		}
	}
	bool resultSubPanelIsOn;
	
	public bool ResultSubPanelIsOn {
		get {
			return resultSubPanelIsOn;
		}
		set {
			resultSubPanelIsOn = value;
		}
	}
	
	bool ResultWireIsOn;
	
	/*public bool ResultPanelIsOn 
	{
		get 
		{
			return resultPanelIsOn;
		}
		set 
		{
			resultPanelIsOn = value;
		}
	}*/
	
	private int test;
	
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
	}
	
	
	void bools()
	{
		panel1IsOn1 = false;
		panel2IsOn1 = false;
		panelCarryIsOn1 = false;
		
		XOrWireIsOn = false;
		intermidiateWire001IsOn1 = false;
		intermidiateWire002IsOn1 = false;
		intermidiateWire003IsOn1 = false;
		intermidiateWire004IsOn1 = false;
		intermidiateWire005IsOn1 = false;
		intermidiateWire006IsOn1 = false;
		
		
		CarryWire001IsOn1 = false;
		CarryWire002IsOn1 = false;
		CarryWire003IsOn1 = false;
		
		carryResultWireIsOn = false;
		resultPanelIsOn = false;
		ResultWireIsOn = false;
		
		
		
	}
	
	void Shortcuts()
	{
		if(Input.GetKeyDown(KeyCode.Alpha3))
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
		
		if(Input.GetKeyDown(KeyCode.Alpha4))
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
	}
	
	void Adder1()
	{
		bool on = _adderV1.CarryResultWireIsOn;
				if(on == true)
				{
					panelCarryIsOn1 = true;
				}
				else
				{
					panelCarryIsOn1 = false;
				}
		
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
			wire108.GetComponent<Renderer>().material.color = Color.green;
			wire109.GetComponent<Renderer>().material.color = Color.green;
			
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
			wire108.GetComponent<Renderer>().material.color = Color.red;
			wire109.GetComponent<Renderer>().material.color = Color.red;
			
			Notwire001.GetComponent<Renderer>().material.color = Color.green;
			Notwire003.GetComponent<Renderer>().material.color = Color.green;
			
		}
		bool SubOn = _mux.SubPanelIsOn;
		if(panel2IsOn1 == true)
		{
			panel2.GetComponent<Renderer>().material.color = Color.green;
			XOrWire001.GetComponent<Renderer>().material.color = Color.green;
			
			if(!SubOn)
			{
				XOrWireIsOn = true;
				
				wire201.GetComponent<Renderer>().material.color = Color.green;
				wire202.GetComponent<Renderer>().material.color = Color.green;
				wire203.GetComponent<Renderer>().material.color = Color.green;
				wire204.GetComponent<Renderer>().material.color = Color.green;
				wire205.GetComponent<Renderer>().material.color = Color.green;
				wire206.GetComponent<Renderer>().material.color = Color.green;
				wire207.GetComponent<Renderer>().material.color = Color.green;
				wire208.GetComponent<Renderer>().material.color = Color.green;
				wire209.GetComponent<Renderer>().material.color = Color.green;
				wire210.GetComponent<Renderer>().material.color = Color.green;
				
				Notwire002.GetComponent<Renderer>().material.color = Color.red;
				Notwire005.GetComponent<Renderer>().material.color = Color.red;
			}
			else
			{
				XOrWireIsOn = false;
				wire201.GetComponent<Renderer>().material.color = Color.red;
				wire202.GetComponent<Renderer>().material.color = Color.red;
				wire203.GetComponent<Renderer>().material.color = Color.red;
				wire204.GetComponent<Renderer>().material.color = Color.red;
				wire205.GetComponent<Renderer>().material.color = Color.red;
				wire206.GetComponent<Renderer>().material.color = Color.red;
				wire207.GetComponent<Renderer>().material.color = Color.red;
				wire208.GetComponent<Renderer>().material.color = Color.red;
				wire209.GetComponent<Renderer>().material.color = Color.red;
				wire210.GetComponent<Renderer>().material.color = Color.red;
				
				Notwire002.GetComponent<Renderer>().material.color = Color.green;
				Notwire005.GetComponent<Renderer>().material.color = Color.green;
			}
		}
		else
		{
			panel2.GetComponent<Renderer>().material.color = Color.red;
			XOrWire001.GetComponent<Renderer>().material.color = Color.red;
			
			if(!SubOn)
			{
				XOrWireIsOn = false;
				wire201.GetComponent<Renderer>().material.color = Color.red;
				wire202.GetComponent<Renderer>().material.color = Color.red;
				wire203.GetComponent<Renderer>().material.color = Color.red;
				wire204.GetComponent<Renderer>().material.color = Color.red;
				wire205.GetComponent<Renderer>().material.color = Color.red;
				wire206.GetComponent<Renderer>().material.color = Color.red;
				wire207.GetComponent<Renderer>().material.color = Color.red;
				wire208.GetComponent<Renderer>().material.color = Color.red;
				wire209.GetComponent<Renderer>().material.color = Color.red;
				wire210.GetComponent<Renderer>().material.color = Color.red;
				
				Notwire002.GetComponent<Renderer>().material.color = Color.green;
				Notwire005.GetComponent<Renderer>().material.color = Color.green;
			}
			else
			{
				XOrWireIsOn = true;
				
				wire201.GetComponent<Renderer>().material.color = Color.green;
				wire202.GetComponent<Renderer>().material.color = Color.green;
				wire203.GetComponent<Renderer>().material.color = Color.green;
				wire204.GetComponent<Renderer>().material.color = Color.green;
				wire205.GetComponent<Renderer>().material.color = Color.green;
				wire206.GetComponent<Renderer>().material.color = Color.green;
				wire207.GetComponent<Renderer>().material.color = Color.green;
				wire208.GetComponent<Renderer>().material.color = Color.green;
				wire209.GetComponent<Renderer>().material.color = Color.green;
				wire210.GetComponent<Renderer>().material.color = Color.green;
				
				Notwire002.GetComponent<Renderer>().material.color = Color.red;
				Notwire005.GetComponent<Renderer>().material.color = Color.red;
			}
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
		
		
		
		if(!panel1IsOn1 && !XOrWireIsOn && panelCarryIsOn1)
		{
			intermidiateWire001IsOn1 = true;
		}
		else
		{
			intermidiateWire001IsOn1 = false;
		}
		
		if(!panel1IsOn1 && XOrWireIsOn && !panelCarryIsOn1)
		{
			intermidiateWire002IsOn1 = true;
		}
		else
		{
			intermidiateWire002IsOn1 = false;
		}
		
		if(panel1IsOn1 && !XOrWireIsOn && !panelCarryIsOn1)
		{
			intermidiateWire003IsOn1 = true;
		}
		else
		{
			intermidiateWire003IsOn1 = false;
		}
		
		if(panel1IsOn1 && XOrWireIsOn && panelCarryIsOn1)
		{
			intermidiateWire004IsOn1 = true;
		}
		else
		{
			intermidiateWire004IsOn1 = false;
		}
		
		if(panel1IsOn1 && XOrWireIsOn)
		{
			CarryWire001IsOn1 = true;
			intermidiateWire005IsOn1 = true;
		}
		else
		{
			CarryWire001IsOn1 = false;
			intermidiateWire005IsOn1 = false;
		}
		if(panel1IsOn1 && panelCarryIsOn1)
		{
			CarryWire002IsOn1 = true;
		}
		else
		{
			CarryWire002IsOn1 = false;
		}
		if(XOrWireIsOn && panelCarryIsOn1)
		{
			CarryWire003IsOn1 = true;
		}
		else
		{
			CarryWire003IsOn1 = false;
		}
		if(panel1IsOn1||XOrWireIsOn)
		{
			intermidiateWire006IsOn1 = true;
		}
		else
		{
			intermidiateWire006IsOn1 = false;
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
		if(intermidiateWire005IsOn1)
		{
			intermidiateWire501.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire502.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire503.GetComponent<Renderer>().material.color = Color.green;
			
			MuxAndpanel.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			intermidiateWire501.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire502.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire503.GetComponent<Renderer>().material.color = Color.red;
			
			MuxAndpanel.GetComponent<Renderer>().material.color = Color.red;
			
		}
		if(intermidiateWire006IsOn1)
		{
			intermidiateWire601.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire602.GetComponent<Renderer>().material.color = Color.green;
			intermidiateWire603.GetComponent<Renderer>().material.color = Color.green;
			
			MuxOrPanel.GetComponent<Renderer>().material.color = Color.green;
			
		}
		else
		{
			intermidiateWire601.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire602.GetComponent<Renderer>().material.color = Color.red;
			intermidiateWire603.GetComponent<Renderer>().material.color = Color.red;
			
			MuxOrPanel.GetComponent<Renderer>().material.color = Color.red;
			
			
		}
		
		if(intermidiateWire001IsOn1 || intermidiateWire002IsOn1 || intermidiateWire003IsOn1 || intermidiateWire004IsOn1)
		{
			resultWire.GetComponent<Renderer>().material.color = Color.green;
			resultWire002.GetComponent<Renderer>().material.color = Color.green;
			ResultWireIsOn = true;
			
			bool SumOn = _mux.SumPanelIsOn;
			//			if(SumOn)
			//			{
			resultWireSum.GetComponent<Renderer>().material.color = Color.green;
			resultWireSub.GetComponent<Renderer>().material.color = Color.green;
			
			resultPanel.GetComponent<Renderer>().material.color = Color.green;
			MuxSubPanel.GetComponent<Renderer>().material.color = Color.green;
			
			resultPanelIsOn = true;
			resultSubPanelIsOn = true;
			
			
			//			}
			
			
		}
		else
		{
			bool SumOn = _mux.SumPanelIsOn;
			
			resultWire.GetComponent<Renderer>().material.color = Color.red;
			resultWire002.GetComponent<Renderer>().material.color = Color.red;
			ResultWireIsOn = false;
			
			//			if(!SumOn && !ResultWireIsOn)
			//			{
			resultWireSum.GetComponent<Renderer>().material.color = Color.red;
			resultWireSub.GetComponent<Renderer>().material.color = Color.red;
			
			resultPanel.GetComponent<Renderer>().material.color = Color.red;
			MuxSubPanel.GetComponent<Renderer>().material.color = Color.red;
			
			resultPanelIsOn = false;
			resultSubPanelIsOn = false;
			
			//			}
			
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
			carryResultWireIsOn = true;
		}
		else
		{
			CarryResultWire.GetComponent<Renderer>().material.color = Color.red;
			carryResultWireIsOn = false;
		}
		
	}

	
	
}
