using System.Collections;
using TMPro;
using Unity.Behavior;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Customer : MonoBehaviour
{
    
    public FoodOrder Order
    {
        get; private set;
    }
    
    
    [SerializeField] public BehaviorGraphAgent behaviorGraphAgent;
    [SerializeField] SayOrder sayOrderChannel;
    public Transform behind;

    public Transform orderCounter;
    public Transform waitingArea;
    public Transform pickupCounter;
    public Transform door;

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

        behaviorGraphAgent.BlackboardReference.SetVariableValue<Transform>("Order Counter", orderCounter);
        behaviorGraphAgent.BlackboardReference.SetVariableValue<Transform>("Waiting Area", waitingArea);
        behaviorGraphAgent.BlackboardReference.SetVariableValue<Transform>("Pickup Counter", pickupCounter);
        behaviorGraphAgent.BlackboardReference.SetVariableValue<Transform>("Door", door);
        //navMeshAgent = GetComponent<NavMeshAgent>();
        //navMeshAgent.SetDestination(Target.position);
        //navMeshAgent.enabled = true;
    }

    private void GenerateOrder()
    {
        Order = new FoodOrder();
    }
}
