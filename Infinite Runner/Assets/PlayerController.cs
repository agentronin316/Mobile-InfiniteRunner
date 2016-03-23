using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Jump", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Jump", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Slide", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("Slide", false);
        }



    }
}
