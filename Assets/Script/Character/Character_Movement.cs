using UnityEngine;
using System.Collections;

public class Character_Movement : MonoBehaviour {

    private bool IsMoving = false;      //Définit si le Player est en mouvement ou non
    private float Movement = 0.15f;      //Vitesse de déplacement du Player

    // Use this for initialization
    void Start () {

        this.transform.position = new Vector3(0, 1, 0);
	}

    void Update()
    {
        if (Input.GetKey("z")) //&& IsMoving == false
        {
            StartCoroutine(UpMovement());
        }
        if (Input.GetKey("s") )
        {
            StartCoroutine(BackMovement());
        }
        if (Input.GetKey("d") )
        {
            StartCoroutine(RightMovement());
        }
        if (Input.GetKey("q") )
        {
            StartCoroutine(LeftMovement());
        }

    }

    IEnumerator UpMovement()
    {
        IsMoving = true;
        transform.position = (transform.position + (transform.forward * Movement));
        yield return null;
        IsMoving = false;
    }
    IEnumerator BackMovement()
    {
        IsMoving = true;
        transform.position = transform.position - (transform.forward * Movement);
        yield return null;
        IsMoving = false;
    }
    IEnumerator RightMovement()
    {
        IsMoving = true;
        transform.position = transform.position + (transform.right * Movement);
        yield return null;
        IsMoving = false;
    }

    IEnumerator LeftMovement()
    {
        IsMoving = true;
        transform.position = transform.position - (transform.right * Movement);
        yield return null;
        IsMoving = false;
    }

}


