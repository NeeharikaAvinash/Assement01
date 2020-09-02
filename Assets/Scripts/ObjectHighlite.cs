using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHighlite : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.localScale = new Vector2(1.05f, 1.05f);
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
   
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.localScale = new Vector2(1f, 1f);
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;

        }

    }
}
