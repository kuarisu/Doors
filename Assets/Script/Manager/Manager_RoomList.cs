using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Manager_RoomList : MonoBehaviour {

    public List<GameObject> PossibleRooms = new List<GameObject>();
    public int DirectionSpawn = 0;
    private int NbRoom = 0;
    

    public void RoomSpawn()
    {
        int _left = 1;
        int _center = 2;
        int _right = 3;
        if (DirectionSpawn == _left )
        {
            //Spawn deux pièces (une à droite (pos.pièce + larg.pièce) et une en haut (pos.pièce + long.pièce) de la pièce dans laquelle est le perso
        }

        if (DirectionSpawn == _center)
        {
            //Spawn trois pièces (une à gauche (pos.pièce - larg.pièce), une devant(pos.pièce + long.pièce) et une à droite(pos.pièce + larg.pièce))
        }

        if (DirectionSpawn == _right)
        {
            //Spawn deux pièces (une à droite (pos.pièce - larg.pièce), une devant (pos.pièce + long.pièce))
        }
    }

    private void RandomPickRoom()
    {





        //if (Room.GetComponent<>().canSpawn == true)
        //GameObject.Instantiate(Room);
        //Room.transform.name = "Room " + NbRoom;
        //else 
        //RandomPickRoom()

    }

}
