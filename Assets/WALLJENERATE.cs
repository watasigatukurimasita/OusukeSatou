using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WALL : MonoBehaviour
{
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        TargetGenerate();
    }

    private void TargetGenerate() //Targetの生成
    {
        Instantiate(wall, new Vector3(1f, 2f, 3f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
