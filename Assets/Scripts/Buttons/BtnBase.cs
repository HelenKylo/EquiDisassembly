using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 按钮基类
/// </summary>
public class BtnBase : MonoBehaviour {

    public static BtnBase instance;

    private void Awake()
    {
        instance = this;
    }

    /// <summary>
    /// 打开一个UI
    /// </summary>
    public virtual void OpenOperUI(GameObject ui)
    {
        ui.SetActive(true);
    }

    /// <summary>
    /// 关闭一个UI
    /// </summary>
    /// <param name="ui"></param>
    public virtual void CloseOperUI(GameObject ui)
    {
        ui.SetActive(false);
    }

    /// <summary>
    /// 显示一个手柄工具隐藏个对应的柜子工具（根据类型）
    /// </summary>
    /// <param name="obj"></param>
    public virtual void ShowHideOneOperObj(ToolType type)
    {
        ShowToolOperObj(GameManager.instance.toolHandObjs, type);
        HideToolOperObj(GameManager.instance.toolCabObjs, type);
    }

    /// <summary>
    /// 显示一个手柄工具隐藏其他手柄工具，隐藏一个柜子工具显示其他柜子工具
    /// </summary>
    /// <param name="type"></param>
    public virtual void ShowHideMultiOperObj(ToolType type)
    {
        ShowToolHideMultiObj(GameManager.instance.toolHandObjs, type, 2);
        HideToolShowMultiObj(GameManager.instance.toolCabObjs, type, 1);
    }






    /// <summary>
    /// 显示工具数组中的一个对象
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="type"></param>
    public void ShowToolOperObj(GameObject[] obj, ToolType type)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            if (obj[i].GetComponent<DisToolBase>().toolType == type)
                obj[i].GetComponent<DisToolBase>().ToolShowObj();
        }
    }

    /// <summary>
    /// 隐藏工具数组中的一个对象
    /// </summary>
    /// <param name="type"></param>
    public void HideToolOperObj(GameObject[] obj, ToolType type)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            if (obj[i].GetComponent<DisToolBase>().toolType == type)
                obj[i].GetComponent<DisToolBase>().ToolHideObj();
        }
    }

    /// <summary>
    /// 显示一个类型工具，隐藏其他所有类型工具
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="type"></param>
    /// <param name="index"></param>
    public void ShowToolHideMultiObj(GameObject[] obj, ToolType type, int index)
    {
        for (int i = index; i < obj.Length; i++)
        {
            if (obj[i].GetComponent<DisToolBase>().toolType == type)
                obj[i].GetComponent<DisToolBase>().ToolShowObj();
            else
                obj[i].GetComponent<DisToolBase>().ToolHideObj();
        }
    }

    /// <summary>
    /// 隐藏一个类型工具，显示其他所有类型工具
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="type"></param>
    /// <param name="index"></param>
    public void HideToolShowMultiObj(GameObject[] obj, ToolType type, int index)
    {
        for (int i = index; i < obj.Length; i++)
        {
            if (obj[i].GetComponent<DisToolBase>().toolType == type)
                obj[i].GetComponent<DisToolBase>().ToolHideObj();
            else
                obj[i].GetComponent<DisToolBase>().ToolShowObj();
        }
    }

    public void CurrentTool(int index)
    {
        GameManager.instance.currentTool = GameManager.instance.toolHandObjs[index].gameObject;
        print("当前使用的工具为：  " + GameManager.instance.currentTool.name);
    }
}
