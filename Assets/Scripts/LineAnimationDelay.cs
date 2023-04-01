using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAnimationDelay : MonoBehaviour
{
    private float animationDuration = 150.0f;

    private LineRenderer lineRenderer;

    float timer;
    public float delay = 5.0f;

    private void Start()
    {
        
        lineRenderer = GetComponent<LineRenderer>();

        StartCoroutine(AnimateLine());
      

    }

    

    private IEnumerator AnimateLine()
    {
        
        float startTime = Time.time;

        Vector3 startPosition = lineRenderer.GetPosition(0);
        Vector3 endPosition = lineRenderer.GetPosition(1);

        Vector3 pos = startPosition;

        while (pos != endPosition)
        {
            float t = (Time.time - startTime) / animationDuration;
            pos = Vector3.Lerp(pos, endPosition, t);
            
            lineRenderer.SetPosition(1, pos);

            yield return null;
            

            
        }
        

    }
}
