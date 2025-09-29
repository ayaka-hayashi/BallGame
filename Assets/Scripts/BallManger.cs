using UnityEngine;

public class BallManger : MonoBehaviour
{
    PinManager pin;

    void Awake()
    {
        pin = FindObjectOfType<PinManager>();
    }
  void OnCollisionEnter(Collision hit)
    {

        if (hit.gameObject.CompareTag("pin"))
        {
            Debug.Log("ok");
            pin.point++;
            //Destroy(hit.gameObject);
        }
    }
}
