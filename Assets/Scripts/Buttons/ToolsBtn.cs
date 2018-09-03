using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 所有工具菜单按钮
/// </summary>
public class ToolsBtn : BtnBase {

    public ToolType toolType;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClickToolBtn);

        
    }

    public void OnClickToolBtn()
    {
        switch (toolType)
        {
            case ToolType.手套:
                CurrentTool(1);
                ShowHideOneOperObj(toolType);
                GameManager.instance.leftHand.SetActive(false);
                GameManager.instance.rightHand.SetActive(false);
                break;
            case ToolType.套筒扳手:
                CurrentTool(2);
                ShowHideMultiOperObj(toolType);
                break;
            case ToolType.螺栓:
                CurrentTool(3);
                ShowHideMultiOperObj(toolType);
                break;
            default:
                break;
        }
    }
}
