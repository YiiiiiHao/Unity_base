using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPint : MonoBehaviour
{
    List<GameObject> OBJ = new List<GameObject>();
    void Start()
    {
        // Vector3 temp = OBJ.transform.position;
        // print(Camera.main.WorldToScreenPoint(OBJ.transform.position));

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Cubeee = GameObject.CreatePrimitive(PrimitiveType.Sphere);//创建一个球体
            Vector3 V = Input.mousePosition;//获取鼠标位置
            V.z = 20;//鼠标位置的z轴赋值为30
            Cubeee.transform.position = Camera.main.ScreenToWorldPoint(V);//屏幕坐标转世界坐标
            OBJ.Add(Cubeee);


            //  if (Input.GetMouseButtonDown(0))
            // {
            //     GameObject Cubeee = GameObject.CreatePrimitive(PrimitiveType.Sphere);//创建一个球体
            //     Vector3 V = Input.mousePosition;//获取鼠标位置
            //     Cubeee.transform.position = Camera.main.ScreenToWorldPoint(V);//屏幕坐标转世界坐标
            //     OBJ.Add(Cubeee);
            //     if (OBJ.Count > 10)
            //     {
            //     OBJ.RemoveAt(0);
            //    }
            // }
        }

        if (OBJ.Count > 10)
        {
            Destroy(OBJ[0]);
        }
    }


}
