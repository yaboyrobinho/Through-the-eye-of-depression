using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XROffsetGrapInteractable : XRGrabInteractable
{

    private Vector3 initialAttachLocalPos;
    private Quaternion InitialAttachLocatRot;
    // Start is called before the first frame update
    void Start()
    {

        //Create attach point
        if (!attachTransform)
        {
            GameObject grab = new GameObject("Grab Pivot");
            grab.transform.SetParent(transform, false);
            attachTransform = grab.transform;
        }

        initialAttachLocalPos = attachTransform.localPosition;
        InitialAttachLocatRot = attachTransform.localRotation;
    }

    // [System.Obsolete]
    protected override void OnSelectEntering(XRBaseInteractor interactor)
    {
        if (interactor is XRDirectInteractor)
        {
            attachTransform.position = interactor.transform.position;
            attachTransform.rotation = interactor.transform.rotation;

        }
        else
        {
            attachTransform.localPosition = initialAttachLocalPos;
            attachTransform.localRotation = InitialAttachLocatRot;
        }

        base.OnSelectEntering(interactor);
    }
}
