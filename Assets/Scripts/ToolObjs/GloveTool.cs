using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 手套工具
/// </summary>
public class GloveTool : DisToolBase
{
    public override void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CylinderPart>() != null)
        {
            if (other.GetComponent<CylinderPart>().partType == PartType.气缸盖)
            {
                toolIsOther = other.gameObject;
            }
        }
        if (other.name == "定位销子")
        {
            BtnBase.instance.CurrentTool(1);
            toolIsOther = other.gameObject;
        }
        if (other.name == "电机转子")
        {
            BtnBase.instance.CurrentTool(1);
            toolIsOther = other.gameObject;
        }

        if (other.name == "偏心轴")
        {
            BtnBase.instance.CurrentTool(1);
            toolIsOther = other.gameObject;
        }
        if (other.name == "huosai2")
        {
            BtnBase.instance.CurrentTool(1);
            toolIsOther = other.gameObject;
        }

        if (other.name == "huosai1")
        {
            BtnBase.instance.CurrentTool(1);
            toolIsOther = other.gameObject;
        }
    }

    public override void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CylinderPart>() != null)
        {
            if (other.GetComponent<CylinderPart>().partType == PartType.气缸盖)
            {
                toolIsOther = null;
            }
        }
    }
}
