using UnityEngine;
using System.Collections;

public class Room_PetShop : Room_Base
{
    public GameObject VeterinaryRoom;

    private void Awake()
    {
        IsSpawnable = true;
    }

    private void Start ()
    {
        
    }
}
