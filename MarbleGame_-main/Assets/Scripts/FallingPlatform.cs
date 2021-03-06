using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FallingPlatform : MonoBehaviour
{
    public AnimationCurve curve;

    Rigidbody rb;

    Vector3 startingPosition;

    void Start() {
        rb = this.GetComponent<Rigidbody>();
        rb.isKinematic = true;      // not affected by gravity
        startingPosition = this.transform.position;
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            StartCoroutine(ResetPlatform());
        }
    }

    IEnumerator ResetPlatform() {
        yield return new WaitForSeconds(1);             // platform does nothing for 1 second
        rb.isKinematic = false;                         // let the platform fall!
        yield return new WaitForSeconds(3);             // wait 3 seconds
        rb.isKinematic = true;                          // make the platform not move!
        StartCoroutine(LerpPosition());                 // reset the platform's position
        
    }

    IEnumerator LerpPosition() {
        Vector3 endPosition = this.transform.position;  // point A in our lerping.
        float elapsedTime = 0f;                         // the time component of our lerping
        float returnInterval = 1f;                      // the total time of our lerping.
        while(elapsedTime < returnInterval) {
            this.transform.position = Vector3.Lerp(endPosition, startingPosition, curve.Evaluate(elapsedTime / returnInterval));            
            elapsedTime += Time.deltaTime;

            yield return null;
        }

    }
}