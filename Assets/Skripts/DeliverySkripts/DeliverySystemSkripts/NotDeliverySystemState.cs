using UnityEngine;

public class NotDeliverySystemState : MonoBehaviour, IDeliveryState
{
   public DeliverySystem deliverySystem;

    public NotDeliverySystemState(DeliverySystem deliverySystem)
    {
        this.deliverySystem = deliverySystem;
    }
    public void TakeDelivery()
    {
        
        //Вызываю у рандомной точки метод, отвечающий за выдачу заказа, и выключаю все остальные точки
        if (deliverySystem == null)
        {
            Debug.Log("NULL");
        }
        deliverySystem.activeDeliveryPoint = Random.RandomRange(0, deliverySystem.DeliveryPoints.Count);
        for (int i = 0; i < deliverySystem.DeliveryPoints.Count; i++)
        {
            if (i == deliverySystem.activeDeliveryPoint)
            {
                continue;
            }
            deliverySystem.DeliveryPoints[i].TurnOff();
        }
        deliverySystem.DeliveryPoints[deliverySystem.activeDeliveryPoint].TurnOn();
        deliverySystem.DeliveryPoints[deliverySystem.activeDeliveryPoint].GiveOrder();
        deliverySystem.SetState(new DeliverySystemState(deliverySystem));
    }
}
