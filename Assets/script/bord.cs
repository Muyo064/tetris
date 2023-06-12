using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bord : MonoBehaviour
{
    [SerializeField]
    private Transform emptySprite;

    [SerializeField]
    public int height = 30;
    public int width = 10;
    public int header = 8;


    private void Start()
    {
        CreateBoard();
    }

    private void CreateBoard()
    {
        if (emptySprite)
        {
            for (int y = 0;y< height - header; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Transform clone = Instantiate(emptySprite, new Vector3(x, y, 0),Quaternion.identity);

                    clone.transform.parent = transform;
                }
            }
        }
    }


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
