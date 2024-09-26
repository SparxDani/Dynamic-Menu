using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradientLighter : MonoBehaviour
{
    public Light targetLight;
    public Color color1 = new Color(1f, 0f, 0.4f); 
    public Color color2 = new Color(0f, 1f, 0.52f); 
    public float duration = 5f;

    private float t = 0f;
    private bool isIncreasing = true;

    void Start()
    {
        if (targetLight == null)
        {
            targetLight = GetComponent<Light>();
        }
    }

    void Update()
    {
        t += (isIncreasing ? 1 : -1) * Time.deltaTime / duration;

        if (t > 1f)
        {
            t = 1f;
            isIncreasing = false;
        }
        else if (t < 0f)
        {
            t = 0f;
            isIncreasing = true;
        }
        targetLight.color = Color.Lerp(color1, color2, t);
    }
}
