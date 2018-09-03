using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 手柄工具螺栓
/// </summary>
public class BoltTool : DisToolBase
{
    public override void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HelpPos")
        {
            transform.gameObject.SetActive(false);
            other.GetComponent<MeshRenderer>().enabled = true;
        }
        if (other.tag == "HelpPos2")
        {
            transform.gameObject.SetActive(false);
            other.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
