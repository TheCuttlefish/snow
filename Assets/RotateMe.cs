using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0, 5 * Time.deltaTime, 0);
    }
}
