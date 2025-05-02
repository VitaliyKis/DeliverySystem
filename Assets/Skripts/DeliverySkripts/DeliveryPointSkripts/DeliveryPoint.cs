using Unity.VisualScripting;
using UnityEngine;

public class DeliveryPoint : MonoBehaviour
{
    
    public void GiveOrder() // ћетод выдачи заказа, здесь можно много чего сделать
    {
        
    }
    public void ReceiveOrder() // ћетод прин€ти€ заказа, здесь € инвокаю ивент, а в ивент можно напихать что душе угодно
    {
        CustomEventBus.OrderDelivered?.Invoke();
    }
    public void TurnOff()
    {
        this.gameObject.SetActive(false);
    }
    public void TurnOn()
    {
        this.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other) // можно добавть тег игрока, чтобы тригерилс€ только на него
    {
        CustomEventBus.OrderDelivered?.Invoke();
    }
}
