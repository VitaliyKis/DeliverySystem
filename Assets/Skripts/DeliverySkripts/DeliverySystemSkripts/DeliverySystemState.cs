using UnityEngine;

public class DeliverySystemState : MonoBehaviour, IDeliveryState
{
    [SerializeField] DeliverySystem deliverySystem;
    public DeliverySystemState(DeliverySystem deliverySystem)
    {
        this.deliverySystem = deliverySystem;
    }
    public void TakeDelivery()
    {
        for (int i = 0; i < deliverySystem.DeliveryPoints.Count; i++)
        {
            if (i == deliverySystem.activeDeliveryPoint)
            {
                continue;
            }
            deliverySystem.DeliveryPoints[i].TurnOn();

        }
        deliverySystem.SetState(new NotDeliverySystemState(deliverySystem));
    }
}
