using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 螺栓部件是否被激活
/// </summary>
public class BoltPartOnEnable : MonoBehaviour
{
    //private void OnEnable()
    //{
    //    if (transform.name == "BoltFinish1")
    //    {
    //        //GameManager.instance.accNumber = -1;
    //        //GameManager.instance.boltShowNumber = 1;

    //        GameObject.FindWithTag("HelpPos").gameObject.GetComponent<MeshCollider>().enabled = true;
    //        BtnBase.instance.ShowToolOperObj(GameManager.instance.toolCabObjs, ToolType.套筒扳手);
    //        BtnBase.instance.HideToolOperObj(GameManager.instance.toolHandObjs, ToolType.套筒扳手);
    //    }
    //    else if (transform.name == "BoltFinish2")
    //    {
    //        GameManager.instance.accNumber = -1;
    //        GameManager.instance.boltShowNumber = 2;
    //        GameObject[] helpBolts = GameObject.FindGameObjectsWithTag("HelpPos2");

    //        for (int i = 0; i < helpBolts.Length; i++)
    //        {
    //            helpBolts[i].GetComponent<MeshCollider>().enabled = true;
    //            BtnBase.instance.ShowToolOperObj(GameManager.instance.toolCabObjs, ToolType.套筒扳手);
    //            BtnBase.instance.HideToolOperObj(GameManager.instance.toolHandObjs, ToolType.套筒扳手);
    //        }
    //    }
    //    else if (transform.name == "阀板组")
    //    {
    //        GameManager.instance.accNumber = -1;
    //        GameManager.instance.testObjs.GetComponent<MeshCollider>().enabled = true;
    //    }
    //    else if (transform.name == "后端盖")
    //    {
    //        GameManager.instance.accNumber = -1;
    //        GameManager.instance.testObjs2.GetComponent<MeshCollider>().enabled = true;
    //    }
    //    else if (transform.name == "BoltFinish3")
    //    {
    //        GameManager.instance.accNumber = -1;
    //        GameObject.FindWithTag("FrontPart").GetComponent<BoxCollider>().enabled = true;

    //        BtnBase.instance.ShowToolOperObj(GameManager.instance.toolCabObjs, ToolType.套筒扳手);
    //        BtnBase.instance.HideToolOperObj(GameManager.instance.toolHandObjs, ToolType.套筒扳手);

    //        for (int i = 0; i < GameManager.instance.three.Length; i++)
    //        {
    //            GameManager.instance.three[i].GetComponent<MeshCollider>().enabled = true;
    //        }
    //    }
    //    else if (transform.name == "前端盖")
    //    {
    //        GameManager.instance.accNumber = -1;
    //        GameObject.FindWithTag("LocationPart").GetComponent<MeshCollider>().enabled = true;
    //    }
    //    //else if (transform.name == "定位销螺帽")
    //    //{
    //    //    GameManager.instance.accNumber = -1;
    //    //    BtnBase.instance.ShowToolOperObj(GameManager.instance.toolCabObjs, ToolType.套筒扳手);
    //    //    BtnBase.instance.HideToolOperObj(GameManager.instance.toolHandObjs, ToolType.套筒扳手);
    //    //}
    //    else if (transform.name == "定位销子")
    //    {
    //        GameManager.instance.dianjizhuanzi.GetComponent<MeshCollider>().enabled = true;
    //    }
    //}
}
