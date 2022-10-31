using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightTrigger : MonoBehaviour
{
    public GameObject World;
    public float speed;
    bool rotating = false;
    
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
        if (other.gameObject.CompareTag("Ball"))
            //World.transform.Rotate(new Vector3 (0, 0, Time.deltaTime * ), Space.Self);
            //World.transform.Rotate(0.0f, 0.0f, rotateAngle, Space.Self);
            StartCoroutine(rotateObject(World, 3f));
    }

    IEnumerator rotateObject(GameObject gameObjectToMove, float duration)
    {
        if (rotating)
        {
            yield break;
        }
        rotating = true;

        float counter = 0;
        while (counter < duration)
        {
            counter += Time.deltaTime;
            gameObjectToMove.transform.Translate(Vector3.right * speed * Time.deltaTime);
            yield return null;
        }
        rotating = false;
    }
}
