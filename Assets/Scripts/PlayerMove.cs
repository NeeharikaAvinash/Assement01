using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float playerSpeed = 5.0f;
    public int count;
    public bool greenTag, redTag, yellowTag;
    public GameObject currentObj;

    void Start ()
    {
        count = 1;
        greenTag = false;
        redTag = false;
        yellowTag = false;
    }
	
    void Update()
    {

        if ((gameObject.transform.position.x >= -9.4f) && (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)))
        {
            transform.Translate(-1f, 0, 0);
        }
        if ((gameObject.transform.position.x <= 9.4f) && (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)))
        {
            transform.Translate(1f, 0, 0);
        }
        if ((gameObject.transform.position.z <= 9.45f)&& (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)))
        {
            transform.Translate(0, 0, 1f);
        }
        if ((gameObject.transform.position.z >= -9.53f) && (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)))
        {
            transform.Translate(0, 0, -1f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && count <= 20)
        {
            if(greenTag == true)
            {
                currentObj.GetComponent<MeshRenderer>().material.color = Color.green;
                greenTag = false;
                count++;
            }
            if(redTag == true)
            {
                currentObj.GetComponent<MeshRenderer>().material.color = Color.red;
                redTag = false;
                count++;
            }
            if (yellowTag == true)
            {
                currentObj.GetComponent<MeshRenderer>().material.color = Color.yellow;
                yellowTag = false;
                count++;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Green") 
        {
            greenTag = true;
            redTag = false;
            yellowTag = false;

            currentObj = other.gameObject;
        }else if (other.gameObject.tag == "Red")
        {
            redTag = true;
            yellowTag = false;
            greenTag = false;

            currentObj = other.gameObject;
        }else if (other.gameObject.tag == "yellow")
        {
            yellowTag = true;
            greenTag = false;
            redTag = false;

            currentObj = other.gameObject;
        }
    }
}
