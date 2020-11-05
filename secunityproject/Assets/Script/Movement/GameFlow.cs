using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public Transform redobj;
    public Transform blueobj;
    public Transform greenobj;
    public Transform yellowobj;
    public Transform orangeobj;

    public int whichgem;
    public static float destroyGemX = -10;
    public static string lockDestroy = "n";
    public static int remainingturns = 40;
    void Start()
    {
        for (int rowNum = -3; rowNum < 6; rowNum++)
        {
            for (int colNum = -4; colNum < 5; colNum++) {
                whichgem = Random.Range(1, 6);
                if (whichgem == 1) {
                    Instantiate(redobj, new Vector3(colNum, rowNum, 0), redobj.rotation);
                }
                if (whichgem == 2)
                {
                    Instantiate(blueobj, new Vector3(colNum, rowNum, 0), blueobj.rotation);
                }
                if (whichgem == 3)
                {
                    Instantiate(greenobj, new Vector3(colNum, rowNum, 0), greenobj.rotation);
                }
                if (whichgem == 4)
                {
                    Instantiate(yellowobj, new Vector3(colNum, rowNum, 0), yellowobj.rotation);
                }
                if (whichgem > 4)
                {
                    Instantiate(orangeobj, new Vector3(colNum, rowNum, 0), orangeobj.rotation);
                }
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        whichgem = Random.Range(1, 6);
        if (destroyGemX != -10)
        {
            if (whichgem == 1)
            {
                Instantiate(redobj, new Vector3(destroyGemX, 11, 0), redobj.rotation);
            }
            if (whichgem == 2)
            {
                Instantiate(blueobj, new Vector3(destroyGemX, 11, 0), blueobj.rotation);
            }
            if (whichgem == 3)
            {
                Instantiate(greenobj, new Vector3(destroyGemX, 11, 0), greenobj.rotation);
            }
            if (whichgem == 4)
            {
                Instantiate(yellowobj, new Vector3(destroyGemX, 11, 0), yellowobj.rotation);
            }
            if (whichgem < 4)
            {
                Instantiate(orangeobj, new Vector3(destroyGemX, 11, 0), orangeobj.rotation);
            }
            destroyGemX = -10;
            StartCoroutine(resetDelay());


        }

    }
    IEnumerator resetDelay() {
        yield return new WaitForSeconds(2);
        lockDestroy = "n";
    }
}
