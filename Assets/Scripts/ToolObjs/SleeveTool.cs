using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 套筒工具
/// </summary>
public class SleeveTool : DisToolBase
{
    public override void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BoltPart>() != null)
        {
            if (other.GetComponent<BoltPart>().partType == PartType.螺栓)
            {
                transform.SetParent(other.transform);

                switch (other.GetComponent<BoltPart>().boltModelType)
                {
                    case BoltModelType.BOLT_UP001:
                        transform.localPosition = sleeveUpPos;
                        transform.localRotation = sleeveUpRot;
                        break;
                    case BoltModelType.BOLT_DOWN002:
                        break;
                    case BoltModelType.BOLT_LEFT003:
                        transform.localPosition = sleeveLeftPos;
                        transform.localRotation = sleeveLeftRot;
                        break;
                    case BoltModelType.BOLT_RIGHT004:
                        transform.localPosition = sleeveRightPos;
                        transform.localRotation = sleeveRightRot;
                        break;
                    case BoltModelType.BOLT_HELP_UP01:
                        transform.localPosition = sleeveHelpUpPos;
                        transform.localRotation = sleeveHelpUpRot;
                        break;
                    case BoltModelType.BOLT_HELP_RIGHT04:
                        transform.localPosition = sleeveHelpRightPos;
                        transform.localRotation = sleeveHelpRightRot;
                        break;
                    case BoltModelType.BOLT_SPE_01:
                        transform.localPosition = sleeveSpePos;
                        transform.localRotation = sleeveSpeRot;
                        break;
                    default:
                        break;
                }

                toolIsOther = other.gameObject;
                GameManager.instance.assemParent = other.transform.parent.gameObject;
                isToolPost = true;
            }
        }
    }

    public override void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Part>() != null)
        {
            if (other.GetComponent<Part>().partType == PartType.螺栓)
            {
                //GetComponent<MeshRenderer>().enabled = true;
                //transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}
