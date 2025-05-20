using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SimpleARPlacementManager : MonoBehaviour
{
    public GameObject[] flowers;
    public XROrigin _xrOrigin;
    public ARRaycastManager _arRaycastManager;
    public ARPlaneManager _arPlaneManager;
    private List<ARRaycastHit> _hits = new List<ARRaycastHit>();

    private void Update() {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) {
                bool collision = _arRaycastManager.Raycast(touch.position, _hits, TrackableType.PlaneWithinPolygon);
                if (collision && _hits.Count > 0) {
                    GameObject _object = Instantiate(flowers[Random.Range(0, flowers.Length)]);
                    _object.transform.position = _hits[0].pose.position;
                    _object.transform.rotation = _hits[0].pose.rotation; // Align object with plane
                    
                    // Optional: Slightly elevate the object to prevent clipping
                    _object.transform.position += new Vector3(0, 0.05f, 0);

                    // Optional: Parent to XROrigin for proper tracking
                    _object.transform.SetParent(_xrOrigin.transform, true);
                }
                else {
                    //do nothing lol
                }
                foreach(var plane in _arPlaneManager.trackables) {
                    //plane to stay active for visibility
                    plane.gameObject.SetActive(true);
                }
        }
    }
}