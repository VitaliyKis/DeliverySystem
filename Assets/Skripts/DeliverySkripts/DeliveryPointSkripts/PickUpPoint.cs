using UnityEngine;

public class PickUpPoint : MonoBehaviour
{
    
     
    public void ReceiveOrder()
    { 
        CustomEventBus.OrderGave?.Invoke();
        
    }
    public void TurnOff()
    {
        this.gameObject.SetActive(false);
    }
    public void TurnOn()
    {
        this.gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ReceiveOrder();
        }
    }
}
