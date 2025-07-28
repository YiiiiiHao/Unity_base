using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_2 : MonoBehaviour
{
    Vector3 V2;
    Vector3 V3;
    public Transform OBJ;
    // Start is called before the first frame update
    void Start()
    {
    
        // V2 = transform.position;
        // print("原始位置：" + V2);

        // V2 = Camera.main.WorldToScreenPoint(this.transform.position);
        // print("屏幕坐标：" + V2);
    }

    // Update is called once per frame
    void Update()
    {
        //屏幕坐标转Unity世界坐标
        //鼠标的位置就是屏幕坐标
        //V3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // print(Input.mousePosition);//打印鼠标位置
        V3 =Input.mousePosition;
        V3.z = 10;
        OBJ.transform.position = Camera.main.ScreenToWorldPoint(V3);
        // print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
