using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryService : MonoBehaviour
{
    [SerializeField]
    InventoryDataSO _inventoryData;

    [SerializeField]
    InventoryView _view;

    private void Awake()
    {
        InventoryModel model = new(_inventoryData);
        InventoryController controller = new(model, _view);
        controller.Initialize();
    }
}
