﻿using UnityEngine;

public enum ItemType    // 해당 아이템이 필요한 캐릭터 지정 위해
{
    Flog,
    Dog,
    Pig
}

[System.Serializable]
public class Item
{
    public string itemName; //이름
    public int itemValue;
    public int itemprice;   //가격
    public string itemDesc; //설명
    public ItemType itemType;
    public Sprite itemImage; //이미지


    public Item(string _itemName, int _itemValue, int _itemPrice, string _itemDesc, ItemType _itemType, Sprite _itemImage)
    {
        itemName = _itemName;
        itemValue = _itemValue;
        itemprice = _itemPrice;
        itemDesc = _itemDesc;
        itemType = _itemType;
        itemImage = _itemImage;
    }

}
