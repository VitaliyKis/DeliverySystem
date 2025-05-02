using UnityEngine;
using System.Collections.Generic;

public class DeliverySystem : MonoBehaviour
{
    private IDeliveryState deliverySystemState;
    public List<DeliveryPoint> DeliveryPoints;
    public int activeDeliveryPoint; // точка в которую надо отвезти заказ
    

    private void Start()
    {
        deliverySystemState = new NotDeliverySystemState(this);
        CustomEventBus.OrderDelivered += DoActionWithState; //подписываюсь на ивент получения заказа
    }
    private void OnDestroy()
    {
        CustomEventBus.OrderDelivered -= DoActionWithState; //Отписываюсь при уничтожении обьекта

    }
    public void DoActionWithState() //Делаем что-то, в зависимости от состояния системы
    {
        deliverySystemState.TakeDelivery();
    }

    public void SetState(IDeliveryState state)
    {
        deliverySystemState = state;
    }
   
}
