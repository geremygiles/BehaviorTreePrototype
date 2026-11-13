using System.Collections.Generic;
using Unity.Behavior;
using Unity.VisualScripting;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField] private int customerCount = 3;
    [SerializeField] private int checkFrequency = 600;
    private List<Customer> customers = new List<Customer>();
    public int CurrentCount { get { return customers.Count; } }

    public bool SomeoneOrdering
    {
        get
        {
            foreach (var customer in customers)
            {
                customer.behaviorGraphAgent.GetVariable<bool>("Waiting to Order", out BlackboardVariable<bool> ordering);
                if (ordering.Value)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public Customer FirstCustomer
    {
        get
        {
            return customers[0];
        }
    }

    public Transform LastCustomer
    {
        get { return customers[^2].behind.transform; }
    }

    [SerializeField] private GameObject[] customerPrefabs;
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
        Debug.Log(CurrentCount);
    }

    private void CheckSpawn()
    {
        if (customers.Count < customerCount)
        {
            int prefabIndex = Random.Range(0, customerPrefabs.Length);
            GameObject customerObject = Instantiate(customerPrefabs[prefabIndex], transform.position, gameObject.transform.rotation);
            Customer customer = customerObject.GetComponent<Customer>();
            customer.orderCounter = orderCounter;
            customer.waitingArea = waitingArea;
            customer.pickupCounter = pickupCounter;
            customer.door = door;
            customers.Add(customer);
        }
    }

    public void RemoveCustomer(Customer customer)
    {
        customers.Remove(customer);
    }
}
