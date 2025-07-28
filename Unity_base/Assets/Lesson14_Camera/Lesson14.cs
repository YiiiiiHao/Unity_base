using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    Vector3 V;
    public Transform obj;
    // public Camera camera1;
    void Start()
    {
        // //主摄像机的Tag必须是MainCamera 
        // print("主摄像机的名字是" + Camera.main.name);
        // // //获取场景中摄像机的数量
        // print("场景中摄像机的数量是" + Camera.allCamerasCount);

        // Camera[] cameras = Camera.allCameras;
        // print("场景中所有摄像机的数量是：" + cameras.Length);

        // //渲染相关
        // //摄像机剔除前处理的函数
        // Camera.onPreCull += (camera) =>
        // {
        //     print("摄像机剔除前处理函数：" + camera.name);
        // };

        // //摄像机 渲染前处理的函数
        // Camera.onPreRender += (camera) =>
        // {
        //     print("摄像机 渲染前处理函数：" + camera.name);
        // };

        // //摄像机 渲染后处理的函数
        // Camera.onPostRender += (camera) =>
        // {
        //     print("摄像机 渲染后处理函数：" + camera.name);
        // };



        //重要成员
        //1：界面参数
        // Camera.main.depth = 10; //摄像机的深度，值越大，摄像机越在前面

        //2:世界坐标转屏幕坐标
        // print("原始位置：" + this.transform.position);
        print("sdasd");
        // Vector3 C = Input.mousePosition;
        // V = Camera.main.WorldToScreenPoint(this.transform.position);
        // print("屏幕坐标：" + V);

        //3:屏幕坐标转世界坐标
        // Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)); //将屏幕坐标转为世界坐标
        // print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        

    }
    void Update()
    {
        // Vector3 V = Input.mousePosition;//鼠标位置赋值给V
        // V.z = 10;
        // //把本来鼠标的值传给V后，把V的值转为世界坐标，再赋值给物体。
        // obj.transform.position =Camera.main.ScreenToWorldPoint(V);
    }
}
