using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseData : MonoBehaviour
{/**
  * Tutorial link
  * https://github.com/tikonen/blog/tree/master/csvreader
  * */

    List<Dictionary<string, object>> data; 
    public GameObject myCube;//prefab
    int currentEntry = 0; //variable 
    float startDelay = .025f;
    float timeInterval = .05f;

    void Awake()
    {

        data = CSVReader.Read("testco2");//udata is the name of the csv file 

               
    


    }//end Awake()

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("growTree", startDelay, timeInterval);
    }//end Start()

    // Update is called once per frame
    void Update()
    {
    }//end Update()
    void growTree()
    {
        
        if (currentEntry < 25990)
        {
            object dataObject = data[currentEntry]["xco2"];
            float co2Data = System.Convert.ToSingle(dataObject);
            currentEntry++;
            transform.localScale = new Vector3(co2Data, co2Data, co2Data);
            Debug.Log("trueSize = " + co2Data);
        }
        
       
    }

}