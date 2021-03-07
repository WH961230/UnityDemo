using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment{

    public SOEnvironmentBase sOEnvironmentBase;

    public void Init(SOEnvironmentBase sOEnvironmentBase){
        this.sOEnvironmentBase = sOEnvironmentBase;
        CreateEnvironment();
    }

    public void OnUpdate(){
        
    }
    private string environmentAssetPath;

    public GameObject CreateEnvironment() {
        environmentAssetPath = sOEnvironmentBase.environmentAssetPath;
        //到时候需要读取excel配置 环境信息
        string environmentAssetName = "Ground";
        string environmentPointAssetName = "GroundPoint";
        //环境方位信息
        GameObject environmentPointObjTemp = (GameObject)LoadAssetManager.LoadAsset(environmentAssetPath + environmentPointAssetName, AssetType.Prefab);
        //环境游戏物体
        Debug.Log(environmentAssetPath + environmentPointAssetName);

        GameObject environmentObjTemp = (GameObject)LoadAssetManager.LoadAsset(environmentAssetPath + environmentAssetName, AssetType.Prefab);
        //创建实例
        GameObject environmentObj = Object.Instantiate(environmentObjTemp);
        //实例设置位置
        environmentObj.transform.position = environmentPointObjTemp.transform.position;
        //实例设置父物体
        environmentObj.transform.SetParent(GameObject.Find("EnvironmentLayer").transform);

        return environmentObj;
    }
}
