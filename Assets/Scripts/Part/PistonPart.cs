using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonPart : Part
{
    public override void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CylinderPos")
        {
            Destroy(transform.gameObject);
            if (transform.name == "定位销子")
                GameManager.instance.xiaozi.SetActive(true);
            else if (transform.name == "电机转子")
                GameManager.instance.dianjizhuanziwww.SetActive(true);
            else if (transform.name == "偏心轴")
                GameManager.instance.pinxinzhou.SetActive(true);
            else if (transform.name == "huosai2")
                GameManager.instance.huosai2.SetActive(true);
            else if (transform.name == "huosai1")
                GameManager.instance.huosai1.SetActive(true);
        }
    }
}
