using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGen : MonoBehaviour
{

    public GameObject[] top;
    public GameObject[] earth;
    public GameObject[] subEarth;
    public GameObject[] bottom;
    public int width;
    public int height;
    public float scale;

    private void Start()
    {
        for (int i = 0; i < width; i++) 
        {
            for (int j = 0; j < height; j++) 
            {
                float x = i/(float)width * scale;
                float y = j/(float)height * scale;
                float perlin = Mathf.PerlinNoise(x, y);
                Debug.Log("Perlin value: " + perlin);
                Vector2 pos = new Vector2(transform.position.x + i, transform.position.y - j);
                if (j < 1)
                {
                    Instantiate(top[0], pos, Quaternion.identity);
                }
                else if (j >= 1 && j < 50)
                {
                    int rand = Random.Range(0, earth.Length);
                    if (perlin < 0.33f)
                    {
                        Instantiate(earth[0], pos, Quaternion.identity);
                    } 
                    else if (perlin < 0.66f)
                    {
                        Instantiate(earth[1], pos, Quaternion.identity);
                    } 
                    else
                    {
                        Instantiate(earth[1], pos, Quaternion.identity);
                    }
                }
                else if (j >= 50 && j < 100)
                {
                    int rand = Random.Range(0, earth.Length);
                    if (perlin < 0.33f)
                    {
                        Instantiate(subEarth[0], pos, Quaternion.identity);
                    }
                    else if (perlin < 0.66f)
                    {
                        Instantiate(subEarth[1], pos, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(subEarth[2], pos, Quaternion.identity);
                    }
                }
                else
                {
                    int rand = Random.Range(0, earth.Length);
                    if (perlin < 0.33f)
                    {
                        //Instantiate(bottom[0], pos, Quaternion.identity);
                    }
                    else if (perlin < 0.66f)
                    {
                        Instantiate(bottom[0], pos, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(bottom[1], pos, Quaternion.identity);
                    }
                }

    
            }
        }
    }
}
