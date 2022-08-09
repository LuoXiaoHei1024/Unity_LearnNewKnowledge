/*****************************************************
    文件：GoRotate.cs
    作者：#UserName#
    邮箱：#Email#
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRotate : MonoBehaviour
{
    public RenderTexture texture;
    public Camera camera;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime*50);

    }

    public void Btn()
    {
        if (camera.targetTexture == null)
        {
            camera.targetTexture = texture;
        }
        else
        {
            camera.targetTexture = null;
        }
    }
}
