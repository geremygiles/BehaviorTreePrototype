using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "Can Order2", story: "Check [Spawner] if can order", category: "Conditions", id: "8157acc93cd38e8260368dbc3477bdb4")]
public partial class CanOrderCondition : Condition
{
    [SerializeReference] public BlackboardVariable<CustomerSpawner> Spawner;

    /// <summary>
    /// Checks if the customer can order
    /// </summary>
    /// <returns></returns>
    public override bool IsTrue()
    {
        if (Spawner.Value.SomeoneOrdering) return false;
        else return true;
    }

    public override void OnStart()
    {
    }

    public override void OnEnd()
    {
    }
}
