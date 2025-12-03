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

        spriteRenderer.material.color = (dot>0)?Color.white:Color.black;
    }
}
