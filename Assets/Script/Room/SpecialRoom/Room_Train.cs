using UnityEngine;
using System.Collections;

public class Room_Train : Room_Base
{

    public override bool IsSpawnable
    {
        set
        {
            base.IsSpawnable = true;
        }
    }
}
