using UnityEngine;
using System.Collections;

public class PlayerSelection : MonoBehaviour {    
    // Selection Circle
    public GameObject circle;
    public GameObject tc;

    // OnSelect is called by the RTS Selection System
    void OnSelect() {
        Debug.Log("OnSelect");
        circle.SetActive(true);
        tc.GetComponent<Count>().selectedUnits++;
    }
    
    // OnDeselect is called by the RTS Selection System
    void OnDeselect() {
        Debug.Log("OnDeselect");
        circle.SetActive(false);
        tc.GetComponent<Count>().selectedUnits--;
    }
}
