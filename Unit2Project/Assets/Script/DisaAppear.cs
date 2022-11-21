using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisaAppear : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ShowAndHide(Cube, 1.0f)); // 1 second
    }
    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }
}
