using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopData", menuName = "ScriptableObjects/ShopDataSO")]
public class ShopDataSO : ScriptableObject
{
    public ItemContainerSO ItemContainer;

    public TabButtonView ItemTypeTabButtonPrefab;

    public SlotView SlotPrefab;
}
