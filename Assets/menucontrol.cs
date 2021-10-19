using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucontrol : MonoBehaviour
{

    SpriteRenderer sR;

    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool startButton = OVRInput.GetDown(OVRInput.Button.Start);

        if (startButton == true)
        {
            sR.enabled = !sR.enabled;
        }
    }
}
