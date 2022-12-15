using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDestroy1 : MonoBehaviour
{
    public GameObject Door;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Destroy2")
        {
            Door.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
