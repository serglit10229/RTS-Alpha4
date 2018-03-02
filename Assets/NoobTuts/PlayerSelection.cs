using UnityEngine;
using System.Collections;

public class PlayerSelection : MonoBehaviour {    
    // Selection Circle
    public GameObject circle;
    //public GameObject tc;

	public bool BotFactoryT1 = false;
	public bool TankFactoryT1 = false;

	public bool allowStuff = true;
	public bool allowSelect = true;

	public GameObject BotT1UI;
	public GameObject TankT1UI;


	void Update()
	{
		if(BotFactoryT1 == true || TankFactoryT1 == true)
		{
			if (gameObject.GetComponent<CastlePlayer>().overlap == true) 
			{
				
			}
		}

		if (allowSelect == false) 
		{
			OnDeselect ();
		}
		if (BotFactoryT1 == true) 
		{
			Debug.Log ("Set Prefab");
			BotT1UI = GameObject.Find("BotFactoryT1 UI");
		}
	}

    // OnSelect is called by the RTS Selection System
    void OnSelect() {
		if (allowSelect == true) 
		{
			Debug.Log ("OnSelect");
			circle.SetActive (true);
			//tc.GetComponent<Count>().selectedUnits++;

			if (BotFactoryT1 == true && !BotT1UI.activeSelf) {
				BotT1UI.SetActive (true);
				BotT1UI.GetComponent<ButtonController> ().Factory = gameObject;
			}
			if (TankFactoryT1 == true && !TankT1UI.activeSelf) {
				TankT1UI.SetActive (true);
				TankT1UI.GetComponent<ButtonController> ().Factory = gameObject;
			}
		}
    }
    
    // OnDeselect is called by the RTS Selection System
    void OnDeselect() {
        Debug.Log("OnDeselect");
        circle.SetActive(false);
        //tc.GetComponent<Count>().selectedUnits--;

		if (BotFactoryT1 == true && BotT1UI.activeSelf) 
		{
			BotT1UI.SetActive(false);
			BotT1UI.GetComponent<ButtonController> ().Factory = null;
		}
		if (TankFactoryT1 == true && !TankT1UI.activeSelf) 
		{
			TankT1UI.SetActive(true);
			TankT1UI.GetComponent<ButtonController> ().Factory = null;
		}
    }
}
