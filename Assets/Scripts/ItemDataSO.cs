using UnityEngine;

[CreateAssetMenu(fileName = "ItemDataSO", menuName = "ScriptableObjects/ItemDataSO")]
public class ItemDataSO : ScriptableObject
{
    public TagSO NameTag;

    public TagSO TypeTag;

    public Sprite IconSprite;

    public TagSO RarityTag;

    [TextArea(20, 20)]
    public string Description;

    public int BuyPrice;

    public int SellPrice;

    public int Weight;
}
