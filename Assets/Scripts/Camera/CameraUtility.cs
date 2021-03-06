using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUtility
{
    public static IEnumerator Shake(Transform cameraTransform ,float duration, float magnitude)
    {
        Vector3 originalPosition = cameraTransform.localPosition;

        float elapsedTime = 0f;

        while(elapsedTime < duration)
        {
            float x =  Random.Range(-1f, 1f) * magnitude;
            float y =  Random.Range(-1f, 1f) * magnitude;

            cameraTransform.localPosition += new Vector3(x, y, 0f);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        cameraTransform.localPosition = originalPosition;
    }
}
