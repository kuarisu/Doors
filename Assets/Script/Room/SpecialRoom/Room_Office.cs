using UnityEngine;
using System.Collections;

public class Room_Office : Room_Base
{

    public override bool IsSpawnable
    {
        set
        {
            base.IsSpawnable = true;
        }
    }
}
