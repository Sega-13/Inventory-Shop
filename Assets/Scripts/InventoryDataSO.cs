using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryData", menuName = "ScriptableObjects/InventoryDataSO")]
public class InventoryDataSO : ScriptableObject
{
    public ItemContainerSO ItemContainer;

    public int MaxWeight;

    public TabButtonView ItemTypeTabButtonPrefab;

    public SlotView SlotPrefab;

}
