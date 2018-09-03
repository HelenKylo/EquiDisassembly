using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏物体控制主逻辑
/// </summary>
public class GameManager : MonoBehaviour {

    public static GameManager instance;

    #region 关于CameraRig rightHand

    public GameObject rightHandParent; // 右手

    #endregion

    #region 关于工具

    public GameObject[] toolCabObjs; // 柜子工具
    public GameObject[] toolHandObjs; // 手柄工具
    public GameObject leftHand; // 左右手Model
    public GameObject rightHand;

    [HideInInspector]
    public GameObject currentTool; // 当前使用的工具

    #endregion

    #region 音效

    public AudioSource audios;

    #endregion

    #region 预留

    public GameObject testObjs;

    public GameObject testObjs2;

    public GameObject dingwei;

    public GameObject xiaozi;

    public GameObject dianjizhuanzi;

    public GameObject dianjizhuanziwww;

    public GameObject pinxinzhou;

    public GameObject huosai2;

    public GameObject huosai1;

    public GameObject[] three;

    #endregion

    #region 需要重置的变量

    /// <summary>
    /// 需要累计显示放置正确螺栓型号的Index
    /// </summary>
    [HideInInspector]
    public int boltANumber = -1;
    [HideInInspector]
    public int boltBNumber = -1;
    [HideInInspector]
    public int boltCNumber = -1;


    /// <summary>
    /// 累计显示添加要拆卸的下个部件的Collider
    /// </summary>
    [HideInInspector]
    public int willAddColliderPartNumber;

    #endregion

    #region 关于部件放置的正确位置

    /// <summary>
    /// 型号不同的螺栓所放置正确位置的父级
    /// </summary>
    public GameObject boltModelAParent;
    public GameObject boltModelBParent;
    public GameObject boltModelCParent;

    /// <summary>
    /// 所有型号的螺栓
    /// </summary>
    [HideInInspector]
    public BoltPlaceAttr[] boltA;
    [HideInInspector]
    public BoltPlaceAttr[] boltB;
    [HideInInspector]
    public BoltPlaceAttr[] boltC;


    /// <summary>
    /// 气缸盖、密封垫等父级
    /// </summary>
    [HideInInspector]
    public GameObject cylinderPosParent;


    [HideInInspector]
    public int boltShowNumber;

    [HideInInspector]
    public int boltsPos2Number;

    public GameObject[] cylindersPos; // 气缸盖

    [HideInInspector]
    public int accNumber;

    [HideInInspector]
    public GameObject assemParent; // 所触发的部件父级

    #endregion

    #region 部件

    [HideInInspector]
    public GameObject[] cylinderTagTool;

    #endregion

    private void Awake()
    {
        instance = this;
        accNumber = -1;
        boltShowNumber = 0;
        boltsPos2Number = 0;
    }

    private void Start()
    {
        boltA = boltModelAParent.GetComponentsInChildren<BoltPlaceAttr>();
        boltB = boltModelBParent.GetComponentsInChildren<BoltPlaceAttr>();
        boltC = boltModelCParent.GetComponentsInChildren<BoltPlaceAttr>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //if (currentTool != null)    // 缺少判断  当前使用工具所触发的对象
            //{
            //    if (currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<Part>().partType == PartType.螺栓)
            //    {
            //        if (!currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger)
            //        {
            //            if (currentTool.GetComponent<DisToolBase>().isToolPost)
            //            {
            //                currentTool.GetComponent<DisToolBase>().ToolIsOtherTranslate(Vector3.up);
            //                if (!currentTool.GetComponentInParent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitAudio)
            //                {
            //                    audios.PlayOneShot(Audio.instance.LoadAudio("电钻"));
            //                    currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitAudio = true;
            //                }
            //                if (!audios.isPlaying)
            //                {
            //                    currentTool.transform.parent = null;
            //                    currentTool.GetComponent<DisToolBase>().toolIsOther.transform.SetParent(currentTool.transform);
            //                    currentTool.GetComponent<DisToolBase>().ToolSetParent();
            //                    currentTool.GetComponent<DisToolBase>().toolIsOther.GetComponent<BoltPart>().isLimitTrigger = true;
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}
