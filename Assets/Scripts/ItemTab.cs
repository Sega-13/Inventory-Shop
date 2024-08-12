using System.Collections.Generic;

public class ItemTab 
{
    public TagSO ItemType;
    public TabButtonView ButtonView;
    public List<SlotView> Slots;

    public void Show()
    {
        ButtonView.ShowSelectedMarker();
        ShowSlots();
    }

    public void Hide()
    {
        ButtonView.HideSelectedMarker();
        HideSlots();
    }

    void ShowSlots()
    {
        foreach (SlotView slot in Slots)
        {
            slot.Show();
        }
    }

    void HideSlots()
    {
        foreach (SlotView slot in Slots)
        {
            slot.Hide();
        }
    }
}

