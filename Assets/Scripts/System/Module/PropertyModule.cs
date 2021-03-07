using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 属性模块
/// </summary>
public class PropertyModule{

    public PropertyManager propertyManager;
    public void Init(){
        propertyManager = new PropertyManager();
        propertyManager.Init();
    }

    public void OnUpdate(){
        
    }
}
