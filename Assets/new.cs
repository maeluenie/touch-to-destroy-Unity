using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;


public class SomethingNew : MonoBehaviour
{
    // Start is called before the first frame update

    public bool canPlace = false;
    public ARRaycastManager arRayCaseMng;
    private Pose placementPose;


    public GameObject targetIndicator;
    public GameObject spawingObject;

    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlacementPose ();
        UpdateTargetIndicator ();

        if (canPlace && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase) {

            Instantiate ();
        }
        
    }


    private void UpdateTargetIndicator ()
    {
        if (canPlace) {

        }
    }
    private void UpdatePlacementPose()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint (new Vector3 (0.5f, 0.5f, 0.5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit> ();

        arRayCastMng.Raycast (screenCenter, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        canPlace = hits.Count > 0;

        if (canPlace) {
            placementPose = hits [0].pose;

            Vector3 cameraForward = Camera.current.transform.forward;
            Vector3 cameraBearing = new Vector3

    }
}
