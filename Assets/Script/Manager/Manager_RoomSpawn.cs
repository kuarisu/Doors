using UnityEngine;
using System.Collections;

    public enum Direction
    {
        South,
        West,
        East
    }

public class Manager_RoomSpawn : MonoBehaviour {

    public static Manager_RoomSpawn instance = null;

    public Direction m_Direction;

        //Singleton
    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    
    public void RoomSpawn()
    {
        if (m_Direction == Direction.East)
        {
            //Spawn deux pièces (une à droite (pos.pièce + larg.pièce) et une en haut (pos.pièce + long.pièce) de la pièce dans laquelle est le perso
        }

        if (m_Direction == Direction.South)
        {
            //Spawn trois pièces (une à gauche (pos.pièce - larg.pièce), une devant(pos.pièce + long.pièce) et une à droite(pos.pièce + larg.pièce))
        }

        if (m_Direction == Direction.West)
        {
            //Spawn deux pièces (une à droite (pos.pièce - larg.pièce), une devant (pos.pièce + long.pièce))
        }
    }
}
