using UnityEngine;
using TMPro;

public class PinManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    int point = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int score = Point();
      scoreText.text = $"Score : {score}";
    }

    public int Point()
    {
        return point;
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag == "ball")
        {
            point++;
            //Destroy(hit.gameObject);
        }
    }
}