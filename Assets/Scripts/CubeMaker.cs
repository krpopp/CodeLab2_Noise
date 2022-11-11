using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMaker : MonoBehaviour
{

    GameObject[] allCubes;
    Material blueMat;

    int landWidth = 50;
    int landLength = 50;

    // Start is called before the first frame update
    void Start()
    {
        blueMat = Resources.Load("Material/Blue") as Material;
        CubeFactory();
    }

    void CubeFactory(){
        for(int x = 0; x < landWidth; x++){
            for(int y = 0; y < landLength; y++){
                Vector3 newPos = new Vector3(x, 0, y);
                CubeAssembler(newPos);
            }
        }
    }

    void CubeAssembler(Vector3 pos){
        GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newCube.transform.position = pos;
        newCube.AddComponent<BoxCollider>();
        newCube.GetComponent<Renderer>().material = blueMat;
    }

}
