using System;
using UnityEngine;
using UnityEngine.UI;

public class MouseItemData : MonoBehaviour
{
    public Image itemSprite;
    public Text ItemCount;

    private void Awake()
    {
        itemSprite.color = Color.clear;
        ItemCount.text = "";
    }
}
