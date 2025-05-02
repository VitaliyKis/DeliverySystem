using UnityEngine;
using System.Collections.Generic;

public class DeliverySystem : MonoBehaviour
{
   
    public List<DeliveryPoint> deliveryPoints;
    public List<PickUpPoint> pickUpPoints;
    [Space(3)]
    public int activeDeliveryPoint;
  
 


    private void Start()
    {
       
        CustomEventBus.DeliveryPointShowed += ShowDeliveryPoint;
        CustomEventBus.OrderGave += GiveOrder;
        CustomEventBus.OrderDeliveredToReceiver += OrderDelivered;

       
    }
    private void OnDestroy()
    {

        CustomEventBus.DeliveryPointShowed -= ShowDeliveryPoint;
        CustomEventBus.OrderGave -= GiveOrder;
        CustomEventBus.OrderDeliveredToReceiver -= OrderDelivered;


    }
    public void OrderDelivered()
    {
        deliveryPoints[activeDeliveryPoint].TurnOff();
        Debug.Log("Заказ доставлен получателю");
    }
    public void GiveOrder()
    {
        pickUpPoints[activeDeliveryPoint].TurnOff();
        activeDeliveryPoint = Random.RandomRange(0, deliveryPoints.Count);
        deliveryPoints[activeDeliveryPoint].TurnOn();
        Debug.Log("Заказ забран из пункта выдачи");


    }
    public void ShowDeliveryPoint()
    {
        activeDeliveryPoint = Random.RandomRange(0, pickUpPoints.Count);
        pickUpPoints[activeDeliveryPoint].TurnOn();
        Debug.Log("Доставщик получил местонахождения пункта выдачи заказа");

    }

     
   
}
