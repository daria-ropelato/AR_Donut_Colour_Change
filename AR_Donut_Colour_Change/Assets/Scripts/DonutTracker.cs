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
                donutInstance.transform.localEulerAngles = new Vector3(90, 0, 0);// Fix rotation

                // Get the icing mesh renderer inside the instantiated prefab
                Renderer icingRenderer = donutInstance.transform.Find("Icing").GetComponent<Renderer>();

                // Get or add the IcingColorChanger script on the donut instance
                IcingColorChanger icingChanger = donutInstance.GetComponent<IcingColorChanger>();
                if (icingChanger == null)
                    icingChanger = donutInstance.AddComponent<IcingColorChanger>();

                // Assign the icingRenderer and define icing colors (optional, or assign via inspector)
                icingChanger.icingRenderer = icingRenderer;
                icingChanger.icingColors = new Color[] { Color.red, Color.green, Color.blue, Color.yellow }; // example
            }
        }
    }
}
