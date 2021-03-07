using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager{//弹药管理负责弹药的创建
    private List<Bullet> bullets = new List<Bullet>();//弹药集合
    private BulletController bulletController;//角色控制
    private SOBulletBase sOBulletBase;//弹药基础
    private MainSystem mainSystem;

    public void OnUpdate() {//更新
    }

    public void Init(MainSystem parent) {//初始化
        mainSystem = parent;

        sOBulletBase = (SOBulletBase)LoadAssetManager.LoadAsset("Scriptables/SOBulletBase", AssetType.Asset);
        bulletController = new BulletController();

        CreateBullet();//创建弹药
    }

    public void SetBullet(Bullet bullet) {//设置弹药
        bullets.Add(bullet);//添加弹药
    }

    public void CreateBullet() {//创建弹药 - bulletNum 创建数量
        for(int i = 0; i < sOBulletBase.BulletInitNum; i++) {//循环创建弹药数量
            Bullet bullet = new Bullet();//创建弹药
            bullet.Init();//弹药初始化
            SetBullet(bullet);//弹药增加
        }
    }

    public Bullet GetBullet() {//获取弹药
        if (bullets.Count > 0) {
            foreach(Bullet bullet in bullets) {
                if (bullet.bulletObj.activeSelf == false) {
                    bullet.bulletObj.SetActive(true);
                    return bullet;
                }
            }
        }
        return null;
    }
}
