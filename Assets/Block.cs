using UnityEngine;

public class Block : MonoBehaviour
{
    Transform target;
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var v1 = (transform.position-target.position).normalized; 
        var v2 = target.up; 
        var dot = Vector3.Dot(v1, v2);

        var col= (dot>0)?dot:0f;

        if (dot > 0.99f)
        {
            spriteRenderer.material.color = new Color(col, 0, 0);
        }
        else
        {
            spriteRenderer.material.color = new Color(col, col, col);
        }

            
    }
}
