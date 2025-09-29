using Unity.Collections;
using UnityEditor.PackageManager;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject BallPrefab;
    public float x = 0;
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) Shot();
    }
    public void Shot()
    {
        GameObject Ball = Instantiate(
            BallPrefab, new Vector3(x, 10.0f, 0), Quaternion.identity
        );
    }
    
}
