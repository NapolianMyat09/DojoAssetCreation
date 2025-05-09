using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    //Assets
    //Grouped Prefabs
    [SerializeField] GameObject enclosedSpaceWalls;
    //pos values
    float wallX = 582.0582f;
    float wallY = 5.011894f;
    float wallZ = 395.3833f;
    [SerializeField] GameObject mat;
    float matX = 567.2473f;
    float matY = 1.736421f;
    float matZ = 407.2758f;
    [SerializeField] GameObject uniform;
    float uniX = 587.2604f;
    float uniY = 2.071368f;
    float uniZ = 430.2574f;
    [SerializeField] GameObject punchingBags;
    float pbX = 592.8639f;
    float pbY = 6.87815f;
    float pbZ = 392.0995f;
    [SerializeField] GameObject lanterns;
    float lanX = 624.4792f;
    float lanY = 5.889526f;
    float lanZ = 382.1631f;
    [SerializeField] GameObject environment;
    float envX = 567.3903f;
    float envY = 0.1f;
    float envZ = 409.9308f;
    [SerializeField] GameObject animatedChest;
    [SerializeField] GameObject player;

    //Singular Prefabs
    [SerializeField] GameObject table;
    [SerializeField] GameObject door;



    // Start is called before the first frame update
    void Start()
    {
        InstantiateAsset(enclosedSpaceWalls, wallX, wallY, wallZ);
        InstantiateAsset(mat, matX, matY, matZ);
        InstantiateAsset(uniform, uniX, uniY, uniZ);
        InstantiateAsset(punchingBags, pbX, pbY, pbZ);
        InstantiateAsset(lanterns, lanX, lanY, lanZ);
        InstantiateAsset(environment, envX, envY, envZ);
        Instantiate(animatedChest);
        Instantiate(player);

        Instantiate(table);
        Instantiate(door);

        //Cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked; // Locks cursor to center

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateAsset(GameObject asset, float x, float y, float z)
    {
        Vector3 tempPos = new Vector3(x, y, z);
        Instantiate(asset, tempPos, Quaternion.identity);
    }
}
