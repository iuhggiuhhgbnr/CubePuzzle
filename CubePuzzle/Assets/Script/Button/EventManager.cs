using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    static Menu_Button menuEvent_Invoker;
    static UnityAction unityaction_listener;

    public static void AddmenuEvent_Invoker(Menu_Button invoker)
    {
        menuEvent_Invoker = invoker;
        
        if(unityaction_listener != null)
        {
            menuEvent_Invoker.Addmenu_listener(unityaction_listener);
        }
    }

    public static void AddmenuEvent_Listener(UnityAction listener)
    {
        unityaction_listener = listener;

        if(menuEvent_Invoker != null)
        {
            menuEvent_Invoker.Addmenu_listener(listener);
        }
    }


}
