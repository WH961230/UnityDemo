using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSystem{
    public EnvironmentManager environmentManager;
    MainSystem mainSystem;
    public void Init(MainSystem parent) {
        mainSystem = parent;

        environmentManager = new EnvironmentManager();
        environmentManager.Init(parent);
    }

    public void OnUpdate() {

    }
}
