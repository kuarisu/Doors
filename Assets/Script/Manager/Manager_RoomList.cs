using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Manager_RoomList : MonoBehaviour {

    public List<GameObject> PossibleRooms = new List<GameObject>();
    private int NbRoom = 0;
    private GameObject Room;
    private bool m_Spawnable;

    private void RandomPickRoom()
    {
       Room = PossibleRooms[Random.Range(0, PossibleRooms.Count)];

        GetSpawnable();

        if (m_Spawnable == true)
        {
            GameObject.Instantiate(Room);
            Room.transform.name = "Room " + NbRoom;
        }
        else
            RandomPickRoom();

    }

    //GET
    public GetSpawnable()
    {
        return Room.GetComponent<Room_Base>().m_IsSpawnable;
    }

}
