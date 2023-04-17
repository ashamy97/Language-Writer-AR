using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageTracking : MonoBehaviour
{
    [SerializeField]
    private GameObject[] placeablePrefabs;

    
    private ARTrackedImageManager trackedImageManager;
    

    private void Awake()
    {

        trackedImageManager = FindObjectOfType<ARTrackedImageManager>();

        
    }

    private void OnEnable()
    {
        trackedImageManager.trackedImagePrefab = placeablePrefabs[LetterPickerScene.letter_to_focus];
               
    }

    

   
}

    

