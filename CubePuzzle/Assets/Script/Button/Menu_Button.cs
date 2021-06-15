using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Menu_Button : MonoBehaviour
{
    GO_MENU_EVENT go_menu_event = new GO_MENU_EVENT();
    private void Start()
    {
        EventManager.AddmenuEvent_Invoker(this);
    }

   
    public void Addmenu_listener(UnityAction listener)
    {
        go_menu_event.AddListener(listener);
    }

    public void MenuButtonClick()
    {
        print("menu press");
        go_menu_event.Invoke();
    }


}
