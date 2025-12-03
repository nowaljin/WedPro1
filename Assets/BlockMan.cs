using UnityEngine;

public class BlockMan : MonoBehaviour
{
    [SerializeField]
    GameObject blockPrefab;

    void Start()
    {
        FillBlock(10, 10, 0.1f);
    }

    void FillBlock(float w, float h, float size)
    {
        var x0 = -w / 2 + size / 2;
        var y0 = -h / 2 + size / 2;

        for (var y = y0; y < y0 + h; y += size)
        {
            for (var x = x0; x < x0 + w; x += size)
            {
                var go = Instantiate(blockPrefab);
                go.transform.position = new Vector3(x, y, 0);
                go.transform.localScale = Vector3.one * size;
            }
        }
    }
}