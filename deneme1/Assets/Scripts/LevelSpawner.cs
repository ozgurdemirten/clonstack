using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public GameObject[] stackmodel;
    [HideInInspector]
    public GameObject[] stackPrefab = new GameObject[6];
    public GameObject winPrefab;
    private GameObject temp1stack, temp2stack;
    private int level = 1, addNumber = 7;
    float stackNumber=0;
    // Start is called before the first frame update
    void Start()
    {
        randomstackgenerator();
        for (stackNumber = 0; stackNumber > -level - addNumber; stackNumber -= 0.5f)
        {
            Debug.Log("buraya girdi");
            temp1stack = Instantiate(stackPrefab[Random.Range(0, 2)]);
            temp1stack.transform.position =new Vector3(0, stackNumber - 0.01f, 0);
            temp1stack.transform.eulerAngles = new Vector3(0, stackNumber *8, 0);

        }
        temp2stack = Instantiate(winPrefab);
        temp2stack.transform.position = new Vector3(0, stackNumber-0.01f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int deger = 4;
    public void randomstackgenerator()
    {
        int random=Random.Range(0,6);
        Debug.Log("random degeri"+random);
        switch(random)
        {
            case 0:
                for(int i = 0; i < deger; i++)
                {
                    Debug.Log(i);
                    stackPrefab[i] = stackmodel[i];
                     
                }break;
            case 1:
                for (int i = 0; i < deger; i++)
                {
                    Debug.Log(i);
                    stackPrefab[i] = stackmodel[i+5];

                }
                break;
            case 2:
                for (int i = 0; i < deger; i++)
                {
                    Debug.Log(i);
                    stackPrefab[i] = stackmodel[i+10];

                }
                break;
            case 3:
                for (int i = 0; i < deger; i++)
                {
                    Debug.Log(i);
                    stackPrefab[i] = stackmodel[i+15];

                }
                break;
            case 4:
                for (int i = 0; i < deger; i++)
                {
                    Debug.Log(i);
                    stackPrefab[i] = stackmodel[i+20];

                }
                break;
            case 5:
                for (int i = 0; i < deger; i++)
                {
                    Debug.Log(i);
                    stackPrefab[i] = stackmodel[i+25];

                }
                break;
            default: break;
        }
    }
}
