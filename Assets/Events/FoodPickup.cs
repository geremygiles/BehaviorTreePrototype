using System;
using Unity.Behavior;
using UnityEngine;
using Unity.Properties;

#if UNITY_EDITOR
[CreateAssetMenu(menuName = "Behavior/Event Channels/Food Pickup")]
#endif
[Serializable, GeneratePropertyBag]
[EventChannelDescription(name: "Food Pickup", message: "Food Pickup", category: "Events", id: "204760e9b2bb513a2aeeea195b8b5959")]
public sealed partial class FoodPickup : EventChannel { }

