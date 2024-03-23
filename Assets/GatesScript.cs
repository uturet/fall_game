using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatesScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Color colorIn; 
    public Color colorDefault;
    public KeyCode reactKey;
    private SpriteRenderer spriteRenderer;
    public LogicScript logic;
    private int enterCount = 0;
    private int exitCount = 0;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = colorDefault;
        }
        else
        {
            Debug.LogWarning("Sprite Renderer component not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enterCount == exitCount) {
            spriteRenderer.color = colorDefault;
        } else {
            spriteRenderer.color = colorIn;
        }

        if (Input.GetKeyDown(reactKey)) {
            logic.IncrementScore();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enterCount++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        exitCount++;
    }

}
