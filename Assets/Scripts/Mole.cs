using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour {

    public float offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //player loses
        }
    }

   void Rise ()
    {
        transform.Translate(0f, offset, 0f);
    }

    void Burrow ()
    {
        transform.Translate(0f, -offset, 0f);
    }
}
