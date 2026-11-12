using Unity.VisualScripting;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private int customerCount = 3;
    private int currentCount = 0;
    [SerializeField] private GameObject customerPrefab;
    [SerializeField] Transform target;

    private int checkFrequency = 600;
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
            GameObject customerObject = Instantiate(customerPrefab, transform.position, Quaternion.identity);
            Customer customer = customerObject.GetComponent<Customer>();
            customer.Target = target;
            currentCount++;
        }
    }
}
