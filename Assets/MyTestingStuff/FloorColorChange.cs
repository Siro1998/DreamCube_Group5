using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorColorChange : MonoBehaviour
{
    public AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // only be triggered by an object tagged as "Ball"
        if (other.gameObject.CompareTag("Ball")){
            // Get the Renderer component from the new cube
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            // Create a new RGBA color using the Color constructor and store it in a variable
            //Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);
            // Call SetColor using the shader property name "_Color" and setting the color to red
            //cubeRenderer.material.SetColor("_Color", customColor);
            cubeRenderer.material.color = Color.yellow;
            audioSource.Play();
        }
        
    }
    
}
