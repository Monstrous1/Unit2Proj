using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    bool firstCheckpoint = false;
    bool Checkpoint1animationplayed = false;
    private Animation checkpointanimation;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        GameObject Checkpoint1 = GameObject.Find("Warp point");
        checkpointanimation = Checkpoint1.GetComponent<Animation>();
        if (hit.gameObject.tag == "Checkpoint")
        {
            if (!firstCheckpoint && !Checkpoint1animationplayed)
            {
                checkpointanimation.Play("checkpointanimation1");
                firstCheckpoint = true;
                Checkpoint1animationplayed = true;
            }
        }
    }


        
    
}