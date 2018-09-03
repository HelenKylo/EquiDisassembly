using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region 枚举类型

/// <summary>
/// 工具类型
/// </summary>
public enum ToolType
{
    手柄,
    手套,
    笔,
    毛巾,
    套筒扳手,
    螺栓
}

/// <summary>
/// 螺栓样式型号 
/// </summary>
public enum BoltModelType
{
    BOLT_UP001,
    BOLT_DOWN002,
    BOLT_LEFT003,
    BOLT_RIGHT004,
    BOLT_FRONT005,
    BOLT_BEHIND006,

    BOLT_HELP_UP01,
    BOLT_HELP_DOWN02,
    BOLT_HELP_LEFT03,
    BOLT_HELP_RIGHT04,
    BOLT_HELP_FRONT05,
    BOLT_HELP_BEHIND06,

    BOLT_SPE_01
}

/// <summary>
/// 设备部件类型
/// </summary>
public enum PartType
{
    螺栓,
    气缸盖,
    密封垫,
    阀板组,
    后端盖,
    前端盖,
    定位销螺帽,
    销子,
    电机转子,
    偏心轴,
    活塞1,
    活塞2,
    其他
}

/// <summary>
/// 将要拆卸的部件
/// </summary>
public enum WillDisPartType
{
    其他,
    One = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10
}

#endregion

/// <summary>
/// 工具基类
/// </summary>
public class DisToolBase : MonoBehaviour {

    public static DisToolBase instance;

    public ToolType toolType;

    /// <summary>
    /// 工具所触发的拆卸对象
    /// </summary>
    [HideInInspector]
    public GameObject toolIsOther; 

    [HideInInspector]
    public bool isToolPost; // 工具是否就位

    #region 工具初始位置

    [HideInInspector]
    public Vector3 toolPos;
    [HideInInspector]
    public Quaternion toolRos;

    #endregion

    #region 套筒扳手位置、角度

    [HideInInspector]
    public Vector3 sleeveUpPos;
    [HideInInspector]
    public Quaternion sleeveUpRot;
    [HideInInspector]
    public Vector3 sleeveLeftPos;
    [HideInInspector]
    public Quaternion sleeveLeftRot;
    [HideInInspector]
    public Vector3 sleeveRightPos;
    [HideInInspector]
    public Quaternion sleeveRightRot;


    [HideInInspector]
    public Vector3 sleeveHelpUpPos;
    [HideInInspector]
    public Quaternion sleeveHelpUpRot;
    [HideInInspector]
    public Vector3 sleeveHelpRightPos;
    [HideInInspector]
    public Quaternion sleeveHelpRightRot;

    [HideInInspector]
    public Vector3 sleeveSpePos;
    [HideInInspector]
    public Quaternion sleeveSpeRot;

    #endregion

    private void Awake()
    {
        instance = this;
        sleeveUpPos = new Vector3(0, 0, 0.0132f);
        sleeveUpRot = Quaternion.Euler(0, 0, -110f);
        sleeveLeftPos = new Vector3(0, 0, 0.0455f);
        sleeveLeftRot = Quaternion.Euler(0, 0, -90);
        sleeveRightPos = new Vector3(0, 0, 0.0448f);
        sleeveRightRot = Quaternion.Euler(180, 0, 90);


        sleeveHelpUpPos = new Vector3(0, 0, 0.00895f);
        sleeveHelpUpRot = Quaternion.Euler(0, 180, -21.36f);
        sleeveHelpRightPos = new Vector3(0, 0, 0.00634f);
        sleeveHelpRightRot = Quaternion.Euler(Vector3.zero);

        sleeveSpePos = new Vector3(0, 0, 0.0026f);
        sleeveSpeRot = Quaternion.Euler(0, 0, -90);
    }

    public void Start()
    {
        ToolInitPosRo();
    }

    /// <summary>
    /// 工具初始位置角度
    /// </summary>
    public virtual void ToolInitPosRo()
    {
        toolPos = transform.localPosition;
        toolRos = transform.localRotation;
    }

    public virtual void ToolSetParent()
    {
        transform.SetParent(GameManager.instance.rightHandParent.transform);
        transform.localPosition = toolPos;
        transform.localRotation = toolRos;
    }

    /// <summary>
    /// 工具隐藏
    /// </summary>
    public virtual void ToolHideObj()
    {
        transform.gameObject.SetActive(false);
    }

    /// <summary>
    /// 工具显示
    /// </summary>
    public virtual void ToolShowObj()
    {
        transform.gameObject.SetActive(true);
    }

    /// <summary>
    /// 触发器触发
    /// </summary>
    /// <param name="other"></param>
    public virtual void OnTriggerEnter(Collider other)
    {

    }

    public virtual void OnTriggerExit(Collider other)
    {
        
    }

    /// <summary>
    /// 工具触发对象动画
    /// </summary>
    public virtual void ToolIsOtherTranslate()
    {
        switch (toolIsOther.GetComponent<BoltPart>().boltModelType)
        {
            case BoltModelType.BOLT_UP001:
                toolIsOther.transform.Translate(Vector3.forward * Time.deltaTime * 0.01f);
                break;
            case BoltModelType.BOLT_LEFT003:
                toolIsOther.transform.Translate(Vector3.forward * Time.deltaTime * 0.01f);
                break;
            case BoltModelType.BOLT_RIGHT004:
                toolIsOther.transform.Translate(-Vector3.forward * Time.deltaTime * 0.01f);
                break;
            case BoltModelType.BOLT_HELP_UP01:
                toolIsOther.transform.Translate(Vector3.forward * Time.deltaTime * 0.01f);
                break;
            case BoltModelType.BOLT_HELP_RIGHT04:
                toolIsOther.transform.Translate(-Vector3.forward * Time.deltaTime * 0.01f);
                break;
            case BoltModelType.BOLT_SPE_01:
                toolIsOther.transform.Translate(Vector3.forward * Time.deltaTime * 0.01f);
                break;
            default:
                break;
        }
        //toolIsOther.transform.Translate(vecot3 * Time.deltaTime * 0.01f);
    }
}
