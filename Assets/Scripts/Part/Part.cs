using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 设备部件
/// </summary>
public class Part : MonoBehaviour
{
    public PartType partType;

    [HideInInspector]
    public bool isLimitAudio; // 限制音效

    [HideInInspector]
    public bool isLimitTrigger; // 限制扳机键

    [HideInInspector]
    public BoltPart[] boltParts; // 要拆卸的螺栓父级下的所有螺栓

    [HideInInspector]
    public CylinderPart[] cylinderParts;

    public void RemoveCollider()
    {
        if (GetComponent<CapsuleCollider>() != null)
            GetComponent<CapsuleCollider>().enabled = false;

        if (GetComponent<BoxCollider>() != null)
            GetComponent<BoxCollider>().enabled = false;

        if (GetComponent<MeshCollider>() != null)
            GetComponent<MeshCollider>().enabled = false;

        if (GetComponent<SphereCollider>() != null)
            GetComponent<SphereCollider>().enabled = false;
    }

    public void TraShow(GameObject[] objs, int index)
    {
        objs[index].SetActive(true);
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        
    }

    public virtual void OnTriggerExit(Collider other)
    {
        
    }
}
