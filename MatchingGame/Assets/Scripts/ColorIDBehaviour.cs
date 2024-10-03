using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDListData colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
