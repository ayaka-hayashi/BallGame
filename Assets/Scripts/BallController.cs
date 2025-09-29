using Unity.Collections;
using UnityEditor.PackageManager;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject BallPrefab;
    public float x = 0;
    public float y = 0;
    public float z = 0;

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) Shot();
    }
    public void Shot()
    {
        GameObject Ball = Instantiate(
            BallPrefab, new Vector3(x, y, z), Quaternion.identity
        );

    }
   
    
}
