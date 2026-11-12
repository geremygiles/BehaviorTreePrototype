using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/Owner at Counter")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "Owner at Counter", message: "Owner at Counter", category: "Events", id: "6a830b4ec5c5858f1447cf8ba9a10572")]
public sealed partial class OwnerAtCounter : EventChannel { }

