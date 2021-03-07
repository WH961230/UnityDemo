using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType {
    Ammo
}

/// <summary>
/// 子弹
/// </summary>
public class Bullet{
    class BulletInfo {//弹药信息
        private float speed;//速度
        private Vector3 startPoint;//开始位置
        private Vector3 endPoint;//结束位置
        private float gravityRatio;//重力系数
    }

    public GameObject bulletObj;

    public void Init(){//初始化
        bulletObj = InitObject();
        bulletObj.SetActive(false);//初始化游戏物体
        InitAct();//初始化运动
    }

    public GameObject InitObject(){//初始化游戏物体
        GameObject bullet = (GameObject)Object.Instantiate(LoadAssetManager.LoadAsset("Prefabs/ConsumeAsset/Bullet", AssetType.Prefab));//生成弹药
        bullet.transform.SetParent(GameObject.Find("TempLayer").transform);
        return bullet;
    }

    public void InitAct(){//初始化移动
        
    }
}
