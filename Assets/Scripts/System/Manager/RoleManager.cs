using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleManager{

    public List<Role> roles = new List<Role>();
    private RoleFPSController roleFPSController;
    private RoleFPSMotor roleFPSMotor;
    public SORoleBase sORoleBase;

    public void Init() {
        sORoleBase = (SORoleBase)LoadAssetManager.LoadAsset("Scriptables/SORoleBase",AssetType.Asset);
        CreateRole();
    }

    public void OnUpdate() {

    }

    public void CreateRole() {//创建角色
        Role role = new Role();
        role.Init(sORoleBase);
        roles.Add(role);
        GameDataSystem.localRole = role;
    }
}
