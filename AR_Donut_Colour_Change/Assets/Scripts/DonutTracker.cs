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
                donutInstance.transform.localEulerAngles = new Vector3(90, 0, 0);

                // Find the IcingColorChanger component in the instantiated prefab
                var icingColorChanger = donutInstance.GetComponentInChildren<IcingColorChanger>();
                if (icingColorChanger != null)
                {
                    // Find the MeshRenderer of the icing mesh inside the prefab
                    var icingRenderer = donutInstance.transform.Find("Icing")?.GetComponent<MeshRenderer>();
                   
                    if (icingRenderer != null)
                    {
                        icingColorChanger.icingRenderer = icingRenderer;
                    }
                    else
                    {
                        Debug.LogWarning("Icing MeshRenderer not found in prefab.");
                    }
                }
                else
                {
                    Debug.LogWarning("IcingColorChanger script not found in prefab.");
                }
            }
        }
    }
}

