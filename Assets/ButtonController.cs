using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    
	public GameObject Bot1;
    public GameObject Bot2;
    public GameObject Bot3;
    public GameObject Bot4;
    public GameObject Bot5;
    public GameObject Bot6;
    public GameObject Bot7;
    public GameObject Bot8;
    public GameObject Bot9;
    public GameObject Bot10;
    

	public bool BotFactoryT1 = false;
	public bool TankFactoryT1 = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	public void ChangeButton(GameObject factrory) {
		Bot1.gameObject.GetComponent<Button>().colors = ColorBlock.defaultColorBlock;
    }
}
