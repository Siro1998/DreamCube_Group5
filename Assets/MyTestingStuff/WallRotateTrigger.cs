using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotateTrigger : MonoBehaviour
{
    public GameObject World;
    public float rotateAngle;
    bool rotating = false;

    // Start is called before the first frame update
    void Start()
    {
        //rotation2 = Quaternion.Euler(new Vector3(0, 0, rotateAngle));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // only be triggered by an object tagged as "Ball"
        if (other.gameObject.CompareTag("Ball"))
            //World.transform.Rotate(new Vector3 (0, 0, Time.deltaTime * ), Space.Self);
            //World.transform.Rotate(0.0f, 0.0f, rotateAngle, Space.Self);
            
            StartCoroutine(rotateObject(World, new Vector3(0, 0, rotateAngle), 3f));
    }
    
    IEnumerator rotateObject(GameObject gameObjectToMove, Vector3 eulerAngles, float duration)
    {
        if (rotating)
        {
            yield break;
        }
        rotating = true;

        Vector3 newRot = gameObjectToMove.transform.eulerAngles + eulerAngles;

        Vector3 currentRot = gameObjectToMove.transform.eulerAngles;

        float counter = 0;
        while (counter < duration)
        {
            counter += Time.deltaTime;
            gameObjectToMove.transform.eulerAngles = Vector3.Lerp(currentRot, newRot, counter / duration);
            yield return null;
        }
        rotating = false;
    }
}
