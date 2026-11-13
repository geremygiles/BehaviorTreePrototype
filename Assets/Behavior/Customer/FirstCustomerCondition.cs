using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "First Customer", story: "[Customer] is first in [Spawner]", category: "Conditions", id: "c4c4367160e7d472f9866781b338d299")]
public partial class FirstCustomerCondition : Condition
{
    [SerializeReference] public BlackboardVariable<Customer> Customer;
    [SerializeReference] public BlackboardVariable<CustomerSpawner> Spawner;

    public override bool IsTrue()
    {
        if (Spawner.Value.FirstCustomer == Customer) return true;
        else return false;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
