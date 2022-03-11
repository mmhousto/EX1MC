using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    Vector3 Position;
    public Rigidbody sphere;
    public static int mouseClicks;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int lMask = LayerMask.GetMask("Ground");
        Vector3 mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            mouseClicks += 1;
            if(Physics.Raycast(ray, out hit, 100, lMask))
            {
                sphere.AddForce(hit.point - transform.position * 500.0f);
            }
        }


    }

}
