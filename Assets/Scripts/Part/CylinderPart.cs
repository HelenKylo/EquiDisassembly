using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 气缸盖、密封垫、阀板组部件
/// </summary>
public class CylinderPart : Part
{
    public override void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CylinderPos")
        {
            if (transform.name == "后端盖")
            {
                GameManager.instance.cylindersPos[3].SetActive(true);
                GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther = null;
                Destroy(transform.gameObject);
            }
            else if (transform.name == "前端盖")
            {
                GameManager.instance.cylindersPos[4].SetActive(true);
                GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther = null;
                Destroy(transform.gameObject);
            }
            else
            {
                GameManager.instance.accNumber++;
                GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther = null;
                TraShow(GameManager.instance.cylindersPos, GameManager.instance.accNumber);
                Destroy(transform.gameObject);

                // 获取部件的父级
                cylinderParts = GameManager.instance.assemParent.GetComponentsInChildren<CylinderPart>();

                if (0 < cylinderParts.Length)
                {
                    if (cylinderParts[0].GetComponent<MeshCollider>() != null)
                    {
                        cylinderParts[0].GetComponent<MeshCollider>().enabled = true;
                    }
                }
            }
        }
    }
}
