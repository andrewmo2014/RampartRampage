using UnityEngine;
using System.Collections;

public class WallTransSelectableScript : MonoBehaviour {
    

	// Use this for initialization
    
    public GameObject transBlock;
    private GameObject currentBlock;
    
	void Start () {
        currentBlock = (GameObject)Instantiate(transBlock, Vector3.zero, Quaternion.identity);	
	}
	
	// Update is called once per frame
	void Update () {
                        
        Vector3 tempTransBlockPos = currentBlock.transform.position;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
               
        if(Physics.Raycast(ray, out hit)){
            
            //Debug.Log(ray.GetPoint(hit.distance));
            Vector3 hitCoords = ray.GetPoint(hit.distance);
            
            if (hit.transform.tag.Equals("Ground")){
                int xIndex = (int)(hitCoords.x);
                int zIndex = (int)(hitCoords.z);
                
                tempTransBlockPos.x = xIndex + 0.5f;
                tempTransBlockPos.z = zIndex + 0.5f;
            
                Debug.Log(tempTransBlockPos);
                currentBlock.transform.position = tempTransBlockPos;
                
            }
   
            
            
        }
        else{
            currentBlock.transform.position = tempTransBlockPos;
        }

	
	}
}
