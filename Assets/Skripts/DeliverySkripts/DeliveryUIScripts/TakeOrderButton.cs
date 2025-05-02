using UnityEngine;
public class TakeOrderButton: MonoBehaviour
{
    public GameObject takeOrderButton;
    public void InvokeEvent() // Вызов ивента показа точки нахождения пункта выдачи заказа
    {
        CustomEventBus.DeliveryPointShowed.Invoke();
    }
    public void ButtonOff()
    {
        takeOrderButton.SetActive(false);
    }
    public void ButtonOn()
    {
        takeOrderButton.SetActive(true);
    }

    private void Start()
    {
        CustomEventBus.DeliveryPointShowed += ButtonOff;  
        CustomEventBus.OrderDeliveredToReceiver += ButtonOn;
    }
    private void OnDestroy()
    {
        CustomEventBus.DeliveryPointShowed -= ButtonOff;
        CustomEventBus.OrderDeliveredToReceiver -= ButtonOn;
    }

}
