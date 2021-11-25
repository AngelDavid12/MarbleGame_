using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPOS : MonoBehaviour
{
    public int ResetWhen;
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        this.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < ResetWhen)
        {
            Debug.Log("Reseting Pos");
            this.transform.position = startPosition;
        }
    }
}