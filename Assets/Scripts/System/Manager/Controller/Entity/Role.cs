using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role{
    //角色ID
    int id;
    //名称
    string name;

    int Hp;

    int maxHp;

    public GameObject roleObj;

    public RoleFPSController roleFPSController;
    public RoleFPSMotor roleFPSMotor;

    private SORoleBase sORoleBase;

    public void Init(SORoleBase sORoleBase) {
        this.sORoleBase = sORoleBase;

        roleObj = InitObject();

        maxHp = sORoleBase.maxHp;
        this.Hp = maxHp;
    }

    public GameObject InitObject() {
        GameObject rolePointObj = LoadAssetManager.LoadAsset("Prefabs/RoleAsset/RolePoint", AssetType.Prefab) as GameObject;
        Vector3 rolePointObjTran = rolePointObj.transform.position;

        GameObject role = LoadAssetManager.LoadAsset("Prefabs/RoleAsset/Role", AssetType.Prefab) as GameObject;
        GameObject roleObj = Object.Instantiate(role);
        Transform roleObjTran = roleObj.transform;

        roleObjTran.position = rolePointObjTran;

        Transform RoleLayerTran = GameObject.Find("RoleLayer").transform;
        roleObjTran.SetParent(RoleLayerTran);

        roleFPSController = roleObj.GetComponent<RoleFPSController>();
        roleFPSMotor = roleObj.GetComponent<RoleFPSMotor>();

        return roleObj;
    }
}
