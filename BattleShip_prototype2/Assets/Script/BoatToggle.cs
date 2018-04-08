using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatToggle : MonoBehaviour {

    public Component[] shipList;

    void SetShipVisibilityReferenceList(bool[] set)
    {
        for(int i=0; i<shipList.Length; i++)
        {
            shipList[i].gameObject.SetActive(set[i]);
        }
    }
}
