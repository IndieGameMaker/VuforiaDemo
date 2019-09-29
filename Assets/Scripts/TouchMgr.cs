using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMgr : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private Camera arCam;
    public GameObject canvasObj;

    void Start()
    {
        arCam = Camera.main; // GetComponent<Camera>();        
    }

    void Update()
    {
        ray = arCam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10.0f, Color.green);

        if (Input.GetMouseButtonDown(0)
            && Physics.Raycast(ray , out hit, 10.0f))
        {
            if (hit.collider.CompareTag("TIGER"))
            {
                canvasObj.SetActive(!canvasObj.activeSelf);
            }            
        }
    }
}
