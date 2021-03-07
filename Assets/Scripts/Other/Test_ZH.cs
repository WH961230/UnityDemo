using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 委托应用
/// </summary>

public class Test_ZH : MonoBehaviour {
    //UnityEvent也可以完成对所有注册过的UnityAction实现一对多通知
    //Action可以完成简单回调一对一，也可以配合Event利用字典发出Invoke通知指令一对多
    //delegate可以完成简单回调一对一，也可以配合Event利用字典发出Invoke通知指令一对多

    //定义一个 delegate 委托 用来指向函数  _Param参数
    private delegate void _DebugString(string _Param);
    //定义一个 delegate 委托变量事件
    private _DebugString _HandlerDebugString;

    //定义一个 Action 无参委托
    private Action _ActionParameter;

    //定义一个 Action 有参委托
    private Action<string> _ActionStrParameter;

    //定义一个可添加事件  可分为有参和无参
    public UnityEvent _PageEnter = new UnityEvent();

    void Start() {
        EnclosintFunction(99);

        ActionParameter();

        DelegateDebugString();

        EventListener();
    }

    public void EnclosintFunction(int i) {
        //对匿名方法来说的外部变量 包括参数 i
        int _OuterValue = 100;

        //被捕获的外部变量
        string _CaptuerOuter = "HelloWorld";

        Action<int> _Anoymouse = delegate (int obj) {
            string _Str = "捕获外部变量：" + _CaptuerOuter+"," + i.ToString();
            print(_Str);
        };

        _Anoymouse(0);


        if (i == 100) {
            //由于在这个作用域内没有声明匿名方法 因此_NotOuterValue不是外部变量
            int _NotOuterValue = 1000;
            print(_NotOuterValue.ToString());
        }
    }

    public void DebugNameOfChina(string _Str) {
        print("中文名字：" + _Str);
    }
    public void DebugNameOfEnglish(string _Str) {
        print("英文名字：" + _Str);
    }

    //Action 委托
    public void ActionParameter() {
        _ActionStrParameter("String");

        _ActionParameter = delegate {
            print("不带参数委托：_ActionParameter");
        };

        _ActionParameter += delegate {
            print("不带参数委托：_ActionParameter，执行 += 操作");
        };

        _ActionStrParameter = delegate (string _Str) {
            print("带参数委托：_ActionStrParameter" + _Str);
        };
    }

    //Delegate委托
    public void DelegateDebugString() {
        //委托赋值
        _HandlerDebugString = DebugNameOfChina;
        _HandlerDebugString("委托");

        //给委托对象再添加一个事件 （多路广播）
        _HandlerDebugString += DebugNameOfEnglish;
        _HandlerDebugString("WeiTuo");

        //给委托时间减去一个事件
        _HandlerDebugString -= DebugNameOfChina;
        _HandlerDebugString("WeiTuo");
    }

    //自定义事件监听
    public void EventListener() {
        //Delegate委托事件添加
        _PageEnter.AddListener(DelegateDebugString);

        //Action委托事件添加
        _PageEnter.AddListener(ActionParameter);
    }
}