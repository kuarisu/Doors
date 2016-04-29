using UnityEngine;
using System.Collections;

public class Character_Direction : MonoBehaviour {

	void OnTriggerEnter(Collider col)
    {
        if (col.tag == "East")
        {
            col.transform.parent.GetComponent<Room_Base>().DefineDirectionEast();
        }
        if (col.tag == "South")
        {
            col.transform.parent.GetComponent<Room_Base>().DefineDirectionSouth();
        }
        if (col.tag == "West")
        {
            col.transform.parent.GetComponent<Room_Base>().DefineDirectionWest();
        }

    }
}
