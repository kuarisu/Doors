using UnityEngine;
using System.Collections;

public class Room_Veterinary : Room_Base
{
    private void Awake()
    {
        IsSpawnable = false;
    }

    public void ChangeSpawnable()
    {
        if (IsSpawnable == true)
            IsSpawnable = false;

        if (IsSpawnable == false)
            IsSpawnable = true;
    }
}
