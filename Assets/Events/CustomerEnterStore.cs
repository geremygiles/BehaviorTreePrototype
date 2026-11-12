using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/Customer Enter Store")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "Customer Enter Store", message: "Customer Enter", category: "Events", id: "e6caaca1453bbc165e67eeebbd5a52df")]
public sealed partial class CustomerEnterStore : EventChannel { }

