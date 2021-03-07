using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour{
    public event Action<uint> onClick;
    private uint i = 0;

    private void Start(){
        onClick += OnClick;
        onClick += OnClick;
        onClick += OnClick;
        onClick += OnClick2;
        onClick += OnClick;
        onClick += OnClick;
        onClick += OnClick2;
    }

    private void Update() {
        if (Input.GetMouseButtonUp(0)) {
            Delegate[] list = onClick.GetInvocationList();

            Debug.LogError("存在在" + Array.IndexOf(list, (Action<uint>)OnClick2));

            //for (int i = 0; i < list.Length; i++ )
            //{
            //    if(list[i].Equals((Action<uint>)OnClick))
            //    {

            //    }
            //}
        }
    }
    private void OnClick(uint i) {
        Debug.Log(i);
        i++;
    }

    private void OnClick2(uint i) {

    }
}
