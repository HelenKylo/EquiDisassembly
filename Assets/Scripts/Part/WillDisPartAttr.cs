using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 将要拆卸的部件
/// </summary>
public class WillDisPartAttr : MonoBehaviour {

    public WillDisPartType willDisPartType;

	// Use this for initialization
	void Start () {
		
	}
	 
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        GameManager.instance.willAddColliderPartNumber++;
        WillDisPartAttr[] willDisPartObj = GameObject.FindGameObjectWithTag("DisEquipment").GetComponentsInChildren<WillDisPartAttr>();
        for (int i = 0; i < willDisPartObj.Length; i++)
        {
            if ((int)willDisPartObj[i].willDisPartType == GameManager.instance.willAddColliderPartNumber)
            {
                if (willDisPartObj[i].GetComponent<BoxCollider>() != null)
                    willDisPartObj[i].GetComponent<BoxCollider>().enabled = true;
                else if (willDisPartObj[i].GetComponent<MeshCollider>() != null)
                    willDisPartObj[i].GetComponent<MeshCollider>().enabled = true;
            }
        }
    }
}
