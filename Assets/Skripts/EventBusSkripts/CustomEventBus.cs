using System;
using UnityEngine;

public class CustomEventBus : MonoBehaviour
{
    public static Action DeliveryPointShowed;
    public static Action OrderGave;
    public static Action OrderDeliveredToReceiver;
}
