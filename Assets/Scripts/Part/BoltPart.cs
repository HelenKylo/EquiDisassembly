using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 螺栓部件
/// </summary>
public class BoltPart : Part {

    public BoltModelType boltModelType;

    [HideInInspector]
    public bool isPlayAudio; // 开始播放音频

    public override void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BoltPos")
        {
            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther = null;

            // 显示不同的螺栓放置正确的位置
            switch (boltModelType)
            {
                case BoltModelType.BOLT_UP001:
                    GameManager.instance.boltANumber++;
                    for (int i = 0; i < GameManager.instance.boltA.Length; i++)
                    {
                        GameManager.instance.boltA[GameManager.instance.boltANumber].GetComponent<MeshRenderer>().enabled = true;
                    }
                    break;
                case BoltModelType.BOLT_RIGHT004:
                    GameManager.instance.boltBNumber++;
                    for (int i = 0; i < GameManager.instance.boltB.Length; i++)
                    {
                        GameManager.instance.boltB[GameManager.instance.boltBNumber].GetComponent<MeshRenderer>().enabled = true;
                    }
                    break;
                case BoltModelType.BOLT_LEFT003:
                    GameManager.instance.boltCNumber++;
                    for (int i = 0; i < GameManager.instance.boltC.Length; i++)
                    {
                        GameManager.instance.boltC[GameManager.instance.boltCNumber].GetComponent<MeshRenderer>().enabled = true;
                    }
                    break;
                default:
                    print("其他");
                    break;
            }

            Destroy(transform.gameObject);

            // 获取螺栓的父级 
            boltParts = GameManager.instance.assemParent.GetComponentsInChildren<BoltPart>();

            if (0 < boltParts.Length)
            {
                if (boltParts[0].GetComponent<MeshCollider>() == null)
                {
                    boltParts[0].gameObject.AddComponent<MeshCollider>();
                    boltParts[0].GetComponent<MeshCollider>().convex = true;
                    boltParts[0].GetComponent<MeshCollider>().isTrigger = true;
                }
            }
        }
    }
}
