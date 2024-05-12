using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float minScale = 0.9f;
    public float maxScale = 1.1f;
    public float pulseSpeed = 2f;

    private float currentTime;

    // Update is called once per frame
    void Update()
    {        
        currentTime += Time.deltaTime * pulseSpeed * 2 * Mathf.PI;

        float scale = Mathf.Lerp(minScale, maxScale, (Mathf.Sin(currentTime) + 1) / 2);
        transform.localScale = new Vector3(scale, scale, 1f);
    }
}
