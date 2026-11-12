using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/Customer at Counter")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "Customer at Counter", message: "Customer at Counter", category: "Events", id: "b54c972b820bd487800646d726b2576b")]
public sealed partial class CustomerAtCounter : EventChannel { }

