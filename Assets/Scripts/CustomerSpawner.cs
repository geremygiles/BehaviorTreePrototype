using Unity.VisualScripting;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private int customerCount = 3;
    [SerializeField] private int checkFrequency = 600;
    private int currentCount = 0;
    [SerializeField] private GameObject customerPrefab;
    [SerializeField] Transform orderCounter;
    [SerializeField] Transform waitingArea;
    [SerializeField] Transform pickupCounter;
    [SerializeField] Transform door;

    
    private int frameCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        frameCount++;
        if (frameCount >= checkFrequency)
        {
            CheckSpawn();
            frameCount = 0;
        }
        
    }

    private void CheckSpawn()
    {
        if (currentCount < customerCount)
        {
            GameObject customerObject = Instantiate(customerPrefab, transform.position, gameObject.transform.rotation);
            Customer customer = customerObject.GetComponent<Customer>();
            customer.orderCounter = orderCounter;
            customer.waitingArea = waitingArea;
            customer.pickupCounter = pickupCounter;
            customer.door = door;
            currentCount++;
        }
    }
}
