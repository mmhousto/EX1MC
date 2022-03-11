using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundsManager : MonoBehaviour
{

    public GameObject sphereObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(sphereObject);
            Debug.Log("Mouse clicks: " + gameManager.mouseClicks);
        }

    }

}
