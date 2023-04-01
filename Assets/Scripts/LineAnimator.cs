using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAnimator : MonoBehaviour
{
    private float animationDuration = 20.0f;

    private LineRenderer lineRenderer, lineSlashRenderer;
    private Vector3[] linePoints;
    private int pointsCount;
    public GameObject slash;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineSlashRenderer = slash.GetComponent<LineRenderer>();

        //store copies of linerenderer points
        pointsCount = lineRenderer.positionCount;
        linePoints = new Vector3[pointsCount];
        for (int i=0; i < pointsCount; i++)
        {
            linePoints[i] = lineRenderer.GetPosition(i);
        }

        StartCoroutine(AnimateLine());
        StartCoroutine(AnimateSlash());
    }

    private IEnumerator AnimateLine()
    {
        float segmentDuration = animationDuration / pointsCount;

        for (int i=0; i < pointsCount-1; i++)
        {
            float startTime = Time.time;

            Vector3 startPosition = linePoints[i];
            Vector3 endPosition = linePoints[i+1];

            Vector3 pos = startPosition;

            while (pos != endPosition)
            {
                float t = (Time.time - startTime) / segmentDuration;
                pos = Vector3.Lerp(pos, endPosition, t);
                
                for (int j = i + 1; j < pointsCount; j++)
                {
                    lineRenderer.SetPosition(j, pos);
                }

                yield return null;
            }
        }

    }

    private IEnumerator AnimateSlash()
    {
        slash.SetActive(false);
        yield return new WaitForSeconds(1.75f);
        slash.SetActive(true);

        float startTime = Time.time;

        Vector3 startPosition = lineSlashRenderer.GetPosition(0);
        Vector3 endPosition = lineSlashRenderer.GetPosition(1);
        
        Vector3 pos = startPosition;

        while (pos != endPosition)
        {
            
            float t = (Time.time - startTime) / animationDuration;
            pos = Vector3.Lerp(pos, endPosition, t);

            lineSlashRenderer.SetPosition(1, pos);
            
            yield return null;
        }
        

    }
}
