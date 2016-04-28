using UnityEngine;
using System.Collections;

public class Camera_LookAt : MonoBehaviour {

    public Transform target;

	
	void Start () {

	}
	

	void LateUpdate () {

        if (target != null)
        {
            //transform.LookAt(target.position);
        }

    }
}
