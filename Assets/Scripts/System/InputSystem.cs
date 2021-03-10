using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem {

    public static InputSystem instance;
    public void Init() {
        instance = this;
    }

    public void OnUpdate() {

    }

    //按下键盘
    public bool KeyPressDown(KeyCode code) {
        if(code != KeyCode.None) {
            return Input.GetKeyDown(code);
        }
        return false;
    }

    public bool KeyPressUp() {
        return false;
    }

    
    public bool MousePressDown(int code) {
        if(code >= 0) {
            return Input.GetMouseButtonDown(code);
        }
        return false;
    }

    public bool MousePressUp() {
        return false;
    }

    public float GetAxis(string str) {
        return Input.GetAxis(str);
    }
}
