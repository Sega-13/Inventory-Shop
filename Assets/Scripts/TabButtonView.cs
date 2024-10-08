using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabButtonView : MonoBehaviour
{
    public Button Button;
    public TextMeshProUGUI labelText;
    public Image underline;

    TagSO _itemTypeTag;
    public TagSO ItemTypeTag => _itemTypeTag;

    public void SetText(string text)
    => labelText.text = text;

    public void ShowSelectedMarker()
    => underline.enabled = true;

    public void HideSelectedMarker()
    => underline.enabled = false;
}
