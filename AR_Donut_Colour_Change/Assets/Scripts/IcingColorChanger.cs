
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class IcingColorChanger : MonoBehaviour
{
    public Renderer icingRenderer;  // Assign in Inspector
    public Color[] icingColors;     // Array of possible colors

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ChangeIcingColor();
        }
    }

    void ChangeIcingColor()
    {
        if (icingRenderer != null && icingColors.Length > 0)
        {
            int index = Random.Range(0, icingColors.Length);
            icingRenderer.material.color = icingColors[index];
        }
    }
}