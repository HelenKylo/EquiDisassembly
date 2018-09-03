using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightController : MonoBehaviour {

    public SteamVR_TrackedObject leftHand;

    private SteamVR_Controller.Device device;

    // Update is called once per frame
    void FixedUpdate()
    {
        device = SteamVR_Controller.Input((int)leftHand.index);

        //if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        //{
        //    if (GameManager.instance.currentTool != null && GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther != null)  
        //    {
        //        if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<Part>().partType == PartType.螺栓)
        //        {
        //            if (!GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger)
        //            {
        //                if (GameManager.instance.currentTool.GetComponent<DisToolBase>().isToolPost)
        //                {
        //                    if (!GameManager.instance.currentTool.GetComponentInParent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitAudio)
        //                    {
        //                        GameManager.instance.audios.PlayOneShot(Audio.instance.LoadAudio("电钻"));
        //                        GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitAudio = true;
        //                    }

        //                    if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.tag == "HelpPos")
        //                    {
        //                        GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolIsOtherTranslate();  // Vector3.forward

        //                        if (!GameManager.instance.audios.isPlaying)
        //                        {
        //                            BtnBase.instance.ShowToolOperObj(GameManager.instance.toolCabObjs, ToolType.套筒扳手);
        //                            BtnBase.instance.HideToolOperObj(GameManager.instance.toolHandObjs, ToolType.套筒扳手);

        //                            GameObject.FindWithTag("CylinderTool").GetComponent<MeshCollider>().enabled = true;
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameObject.FindWithTag("CylinderTool").gameObject.transform);
        //                            GameManager.instance.accNumber = -1;

        //                            GameManager.instance.currentTool.transform.parent = null;
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolSetParent();

        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger = true;
        //                        }
        //                    }
        //                    else if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.tag == "BoltBackpart")
        //                    {
        //                        GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolIsOtherTranslate();  // -Vector3.forward

        //                        if (!GameManager.instance.audios.isPlaying)
        //                        {
        //                            GameManager.instance.currentTool.transform.parent = null;
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.currentTool.transform);
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolSetParent();
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger = true;
        //                        }
        //                    }
        //                    else if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.tag == "HelpPos2")
        //                    {
        //                        GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolIsOtherTranslate();  // -Vector3.forward

        //                        if (!GameManager.instance.audios.isPlaying)
        //                        {
        //                            GameManager.instance.boltsPos2Number++;
        //                            if (GameManager.instance.boltsPos2Number == 2)
        //                            {
        //                                BtnBase.instance.ShowToolOperObj(GameManager.instance.toolCabObjs, ToolType.套筒扳手);
        //                                BtnBase.instance.HideToolOperObj(GameManager.instance.toolHandObjs, ToolType.套筒扳手);

        //                                GameManager.instance.accNumber = -1;

        //                                GameManager.instance.currentTool.transform.parent = null;
        //                                GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolSetParent();

        //                                GameObject.FindWithTag("RearPart").GetComponent<BoxCollider>().enabled = true;
        //                                GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger = true;
        //                            }
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameObject.FindWithTag("RearPart").gameObject.transform);
        //                        }
        //                    }
        //                    else if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.tag == "BoltFrontpart")
        //                    {
        //                        GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolIsOtherTranslate(); // Vector3.forward

        //                        if (!GameManager.instance.audios.isPlaying)
        //                        {
        //                            GameManager.instance.currentTool.transform.parent = null;
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.currentTool.transform);
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolSetParent();
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger = true;
        //                        }
        //                    }
        //                    else if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.tag == "LocationPart")
        //                    {
        //                        GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolIsOtherTranslate(); // (Vector3.forward)

        //                        if (!GameManager.instance.audios.isPlaying)
        //                        {
        //                            GameManager.instance.currentTool.transform.parent = null;
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.currentTool.transform);
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolSetParent();
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger = true;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolIsOtherTranslate();  // Vector3.forward

        //                        if (!GameManager.instance.audios.isPlaying)
        //                        {
        //                            GameManager.instance.currentTool.transform.parent = null;
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.currentTool.transform);
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolSetParent();
        //                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger = true;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            if (GameManager.instance.currentTool != null)
            {
                if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther != null)
                {

                    if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<Part>().partType == PartType.螺栓)
                    {
                        GameManager.instance.audios.PlayOneShot(Audio.instance.LoadAudio("电钻"));

                        // 开始播放 isPlayAudio = true
                        GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isPlayAudio = true;
                    }

                    if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<Part>().partType == PartType.气缸盖)
                    {
                        GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.rightHandParent.transform);
                    }

                    if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.name == "定位销子")
                    {
                        GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.rightHandParent.transform);
                    }

                    if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.name == "电机转子")
                    {
                        GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.rightHandParent.transform);
                    }

                    if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.name == "偏心轴")
                    {
                        GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.rightHandParent.transform);
                    }

                    if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.name == "huosai2")
                    {
                        GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.rightHandParent.transform);
                    }

                    if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.name == "huosai1")
                    {
                        GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.rightHandParent.transform);
                    }
                }
            }
        }

        if (GameManager.instance.currentTool != null &&
            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther != null)
        {
            if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<Part>().partType == PartType.螺栓)
            {
                if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isPlayAudio)
                {
                    if (!GameManager.instance.audios.isPlaying)
                    {
                        if (GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().boltModelType != BoltModelType.BOLT_HELP_UP01 &&
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().boltModelType != BoltModelType.BOLT_HELP_DOWN02 &&
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().boltModelType != BoltModelType.BOLT_HELP_LEFT03 &&
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().boltModelType != BoltModelType.BOLT_HELP_RIGHT04 &&
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().boltModelType != BoltModelType.BOLT_HELP_FRONT05 &&
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().boltModelType != BoltModelType.BOLT_HELP_BEHIND06)
                        {
                            GameManager.instance.currentTool.transform.parent = null;
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(GameManager.instance.currentTool.transform);
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolSetParent();
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isPlayAudio = false;
                        }
                        else
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

                                    GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(willDisPartObj[i].transform);
                                }
                            }

                            BtnBase.instance.ShowToolOperObj(GameManager.instance.toolCabObjs, ToolType.套筒扳手);
                            BtnBase.instance.HideToolOperObj(GameManager.instance.toolHandObjs, ToolType.套筒扳手);
                            BtnBase.instance.CurrentTool(1);

                            GameManager.instance.currentTool.transform.parent = null;
                            GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolSetParent();

                            GameManager.instance.currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isPlayAudio = false;
                        }
                    }
                    else
                        GameManager.instance.currentTool.GetComponent<DisToolBase>().ToolIsOtherTranslate();
                }
            }
        }
    }
}
