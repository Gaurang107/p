using UnityEngine;

public class EmotionChanger : MonoBehaviour
{
    public Sprite neutralSprite;
    public Sprite happySprite;
    public Sprite sadSprite;
    public Sprite angrySprite;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // H key = Happy
        if (Input.GetKeyDown(KeyCode.H))
        {
            sr.sprite = happySprite;
        }

        // S key = Sad
        if (Input.GetKeyDown(KeyCode.S))
        {
            sr.sprite = sadSprite;
        }

        // A key = Angry
        if (Input.GetKeyDown(KeyCode.A))
        {
            sr.sprite = angrySprite;
        }

        // N key = Neutral
        if (Input.GetKeyDown(KeyCode.N))
        {
            sr.sprite = neutralSprite;
        }
    }
}