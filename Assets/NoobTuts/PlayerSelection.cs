using UnityEngine;
using System.Collections;

public class PlayerSelection : MonoBehaviour {    
    // Selection Circle
    public GameObject circle;
    //public GameObject tc;

	public bool BotFactoryT1 = false;
	public bool TankFactoryT1 = false;

	public GameObject BotT1UI;
	public GameObject TankT1UI;

	void Update()
	{

	}

    // OnSelect is called by the RTS Selection System
    void OnSelect() {
        Debug.Log("OnSelect");
        circle.SetActive(true);
        //tc.GetComponent<Count>().selectedUnits++;

		if (BotFactoryT1 == true && !BotT1UI.activeSelf) 
		{
			BotT1UI.SetActive(true);
		}
		if (TankFactoryT1 == true && !TankT1UI.activeSelf) 
		{
			TankT1UI.SetActive(true);
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
		}
		if (TankFactoryT1 == true && !TankT1UI.activeSelf) 
		{
			TankT1UI.SetActive(true);
		}
    }
}
