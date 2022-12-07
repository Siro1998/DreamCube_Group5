using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightTrigger : MonoBehaviour
{
    //public Material duplicateMaterial;
    public GameObject World;
    public float speed;
    bool rotating = false;
    //private GameObject duplicate;
    //private GameObject block;

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
        if (other.gameObject.CompareTag("Ball")){
            //Debug.Log("Hit");
            //World.transform.Rotate(new Vector3 (0, 0, Time.deltaTime * ), Space.Self);
            //World.transform.Rotate(0.0f, 0.0f, rotateAngle, Space.Self);
            
            StartCoroutine(rotateObject(World, 3f));
        }    
    }

    IEnumerator rotateObject(GameObject gameObjectToMove, float duration)
    {
        if (rotating)
        {
            yield break;
        }
        rotating = true;
        //block = GameObject.FindGameObjectWithTag("BlockOnCollide");
        // if(block!=null){
        //     duplicate = Instantiate(block, block.transform.position+ new Vector3(0,0.001f,0), block.transform.rotation);
        //     Vector3 objectScale = duplicate.transform.localScale;
        //     objectScale.x = 0.79f;
        //     duplicate.transform.localScale = objectScale;
        //     duplicate.GetComponent<FloorColorChange>().enabled = false;
        //     duplicate.tag = "BlockNotOnCollide";
        //     duplicate.GetComponent<Renderer>().material = duplicateMaterial;
        // }
        float counter = 0;
        while (counter < duration)
        {
            counter += Time.deltaTime;
            gameObjectToMove.transform.Translate(Vector3.right * speed * Time.deltaTime);
            yield return null;
        }
        rotating = false;
        //Destroy(duplicate);
    }
}
