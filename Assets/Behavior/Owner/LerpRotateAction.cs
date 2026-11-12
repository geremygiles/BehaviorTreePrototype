using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Lerp Rotate", story: "[Agent] lerps to [vector]", category: "Action", id: "b354faecf2c51bb555f4811d383e40df")]
public partial class LerpRotateAction : Action
{
    [SerializeReference] public BlackboardVariable<Transform> Agent;
    [SerializeReference] public BlackboardVariable<Vector3> Vector;

    Vector3 orignalRotation;

    float lerp = 0f;
    float lerpSpeed = 0.1f;
    protected override Status OnStart()
    {
        orignalRotation = Agent.Value.rotation.eulerAngles;
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        lerp += Time.deltaTime * lerpSpeed;

        Quaternion newRotation = Quaternion.Euler(Vector3.Lerp(orignalRotation, Vector.Value, lerp));

        Agent.Value.rotation = newRotation;

        if (lerp >= 1)
        {
            return Status.Success;
        }
        else return Status.Running;
    }

    protected override void OnEnd()
    {
    }
}

