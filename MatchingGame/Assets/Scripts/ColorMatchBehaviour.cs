using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    public ColorIDListData ColorIDDataListObj;

    private void Awake()
    {
        idObj = ColorIDDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer spriteRenderer)
    {
        var newColor = idObj as ColorID;
        spriteRenderer.color = newColor.value;
    }
}
