using UnityEngine;
using System.Collections;

public class Room_Base : MonoBehaviour {

    public bool m_IsSpawnable;
    int m_AppaearCompteur = 0;
    Direction _Direction;


    public virtual bool IsSpawnable
    {
        get;

    }
        

    ////GET
    //public Direction GetDirection()
    //{
    //    return Manager_RoomSpawn.instance.m_Direction;
    //}


    public void DefineDirectionEast()
    {
        //Lock porte de droite et du bas

        _Direction = Direction.East;
        SetDirection(_Direction);
    }
    public void DefineDirectionSouth()
    {
        //Lock porte du bas
        _Direction = Direction.South;
        SetDirection(_Direction);
    }
    public void DefineDirectionWest()
    {
        //Lock porte de gauche et du bas
        _Direction = Direction.West;
        SetDirection(_Direction);
    }

    //SET
    public void SetDirection(Direction _Direction)
    {
        Manager_RoomSpawn.instance.m_Direction = _Direction;
    }

}


