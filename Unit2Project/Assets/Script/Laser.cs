using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject tpdeath;
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Laser")
        {
            CharacterController controller = GetComponent<CharacterController>();

            if(controller != null)
            {
                controller.enabled = false;
                controller.transform.position = tpdeath.transform.position;
                controller.enabled = true;
            }
        }
    }

}
