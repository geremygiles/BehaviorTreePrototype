using System.Collections;
using TMPro;
using Unity.Behavior;
using UnityEngine;

public class Customer : MonoBehaviour
{
    
    public FoodOrder Order
    {
        get; private set;
    }
    
    
    [SerializeField] BehaviorGraphAgent behaviorGraphAgent;
    [SerializeField] SayOrder sayOrderChannel;
    public Transform Target;

    private void OnEnable()
    {
        if (sayOrderChannel != null)
        {
            //sayOrderChannel.Event += StartOrder;
        }
    }

    private void OnDisable()
    {
        if (sayOrderChannel != null)
        {
            //sayOrderChannel.Event -= StartOrder;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateOrder();
        //StartCoroutine(Speak(order.OrderString));

        behaviorGraphAgent.BlackboardReference.SetVariableValue<Transform>("Order Counter", Target);
        //navMeshAgent = GetComponent<NavMeshAgent>();
        //navMeshAgent.SetDestination(Target.position);
        //navMeshAgent.enabled = true;
    }

    private void GenerateOrder()
    {
        Order = new FoodOrder();
    }
}
