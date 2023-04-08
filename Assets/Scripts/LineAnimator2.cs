using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineAnimator2 : MonoBehaviour
{
    private float animationDuration = 20.0f;

    private LineRenderer lineRenderer;
    private Vector3[] linePoints;
    private int pointsCount;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        

        //store copies of linerenderer points
        pointsCount = lineRenderer.positionCount;
        linePoints = new Vector3[pointsCount];
        for (int i = 0; i < pointsCount; i++)
        {
            linePoints[i] = lineRenderer.GetPosition(i);
        }

        

    }

    private IEnumerator AnimateLine()
    {
        float segmentDuration = animationDuration / pointsCount;

        for (int i = 0; i < pointsCount - 1; i++)
        {
            float startTime = Time.time;

            Vector3 startPosition = linePoints[i];
            Vector3 endPosition = linePoints[i + 1];

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

    public void reanimate()
    {
        StartCoroutine(AnimateLine());
    }
}
