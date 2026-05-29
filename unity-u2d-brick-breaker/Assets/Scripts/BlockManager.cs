using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject blockPrefab;
    public Sprite[] blockColors;
    public int gap = 4;

    public string grid = "0000\n1111\n2222\n3333";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = blockPrefab.GetComponent<SpriteRenderer>();
        //Debug.Log(spriteRenderer.size);
        string[] lines = grid.Split("\n");
        for (int y = 0; y < lines.Length; y++)
        {
            //
            float blockY = -y * (spriteRenderer.size.y + gap);
            //
            string line = lines[y];
            float blocksWidth = (line.Length - 1) * spriteRenderer.size.x;
            float gapsWidth = (line.Length - 1) * gap;
            float halfWidth = (blocksWidth + gapsWidth) / 2;
            for (int x = 0; x < line.Length; x++)
            {
                // Skip empty, make gap
                char c = line[x];
                if (c == ' ')
                    continue;

                float blockX = x * (spriteRenderer.size.x + gap);
                Vector3 position = this.transform.position + new Vector3(blockX - halfWidth, blockY, 0);

                GameObject block = Instantiate(blockPrefab, position, Quaternion.identity, this.transform);
                SpriteRenderer blockSR = block.GetComponent<SpriteRenderer>();
                int blockSpriteIndex = int.Parse(c.ToString());
                Sprite blockSprite = blockColors[blockSpriteIndex];
                blockSR.sprite = blockSprite;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
