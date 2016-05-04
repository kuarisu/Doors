using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Manager_RoomList : MonoBehaviour {

    public List<GameObject> PossibleRooms = new List<GameObject>();
    private GameObject Room;

    public void RandomPickRoom()
    {
        Room = PossibleRooms[Random.Range(0, PossibleRooms.Count)];

        if (GetSpawnable() == true)
           Manager_RoomSpawn.instance.RoomPicked = Room;

        else if (GetSpawnable() == false)
            RandomPickRoom();
    }

    //GET
    public bool GetSpawnable()
    {
        return Room.GetComponent<Room_Base>().IsSpawnable;
    }

}
