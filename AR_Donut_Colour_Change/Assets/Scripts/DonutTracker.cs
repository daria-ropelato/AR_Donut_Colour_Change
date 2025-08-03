using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DonutTracker : MonoBehaviour
{
    public GameObject donutPrefab;
    private GameObject donutInstance;

    void OnEnable()
    {
        var trackedImages = FindObjectOfType<ARTrackedImageManager>();
        trackedImages.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        var trackedImages = FindObjectOfType<ARTrackedImageManager>();
        trackedImages.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var image in args.added)
        {
            if (donutInstance == null)
            {
                donutInstance = Instantiate(donutPrefab, image.transform);
                donutInstance.transform.localPosition = Vector3.zero;

                // Fix rotation
                donutInstance.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
        }
    }
}