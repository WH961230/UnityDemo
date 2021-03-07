using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleSystem{

    RoleManager roleManager;
    PropertyManager propertyManager;

    MainSystem mainSystem;

    public void Init(MainSystem parent) {
        mainSystem = parent;

        roleManager = new RoleManager();
        propertyManager = new PropertyManager();

        roleManager.Init();
        propertyManager.Init();
    }

    public void OnUpdate(){
        
    }
}
