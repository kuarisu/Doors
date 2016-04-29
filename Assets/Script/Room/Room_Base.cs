using UnityEngine;
using System.Collections;

public class Room_Base : MonoBehaviour {

        bool m_IsSpawnable;
        int m_AppaearCompteur = 0;
        Direction _Direction;

        ////GET
        //public Direction GetDirection()
        //{
        //    return Manager_RoomSpawn.instance.m_Direction;
        //}

        public void DefineDirectionEast()
        {
            //Lock porte de droite et du bas
        }
        public void DefineDirectionSouth()
        {
            //Lock porte du bas
        }
        public void DefineDirectionWest()
        {
            //Lock porte de gauche et du bas
        }

    //SET
    public void SetDirection(Direction _Direction)
        {
            Manager_RoomSpawn.instance.m_Direction = _Direction;
        }

}


