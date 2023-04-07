using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterEAnimator : MonoBehaviour
{
    private float animationDuration = 20.0f;

    private LineRenderer lineRenderer, secondSlashRenderer, thirdSlashRenderer;
    private Vector3[] linePoints;
    private int pointsCount;
    public GameObject secondSlash, thirdSlash;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        secondSlashRenderer = secondSlash.GetComponent<LineRenderer>();
        thirdSlashRenderer = thirdSlash.GetComponent<LineRenderer>();

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

    private IEnumerator AnimateSecondSlash()
    {
        secondSlash.SetActive(false);
        yield return new WaitForSeconds(1.75f);
        secondSlash.SetActive(true);

        float startTime = Time.time;

        Vector3 startPosition = secondSlashRenderer.GetPosition(0);
        Vector3 endPosition = secondSlashRenderer.GetPosition(1);

        Vector3 pos = startPosition;

        while (pos != endPosition)
        {

            float t = (Time.time - startTime) / animationDuration;
            pos = Vector3.Lerp(pos, endPosition, t);

            secondSlashRenderer.SetPosition(1, pos);

            yield return null;
        }


    }

    private IEnumerator AnimateThirdSlash()
    {
        thirdSlash.SetActive(false);
        yield return new WaitForSeconds(3.1f);
        thirdSlash.SetActive(true);

        float startTime = Time.time;

        Vector3 startPosition = thirdSlashRenderer.GetPosition(0);
        Vector3 endPosition = thirdSlashRenderer.GetPosition(1);

        Vector3 pos = startPosition;

        while (pos != endPosition)
        {

            float t = (Time.time - startTime) / animationDuration;
            pos = Vector3.Lerp(pos, endPosition, t);

            thirdSlashRenderer.SetPosition(1, pos);

            yield return null;
        }


    }

    public void reanimate()
    {
        StartCoroutine(AnimateLine());
        StartCoroutine(AnimateSecondSlash());
        StartCoroutine(AnimateThirdSlash());
    }
}
