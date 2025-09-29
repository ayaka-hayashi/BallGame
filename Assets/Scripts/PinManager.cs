using UnityEngine;
using TMPro;

public class PinManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    
    public int point = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(scoreText.text);
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

   
}