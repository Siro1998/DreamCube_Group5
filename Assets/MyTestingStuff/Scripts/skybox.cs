using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox : MonoBehaviour
{
    public float Skyboxspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 282.0f+Time.time*Skyboxspeed);
    }
}
