using UnityEngine;
using System.Collections;

public class HexGenOrigin : MonoBehaviour {

    public GameObject Hex;
    

    public float hexWidth;
    public float hexHeight;
    public int numRows;

    Vector3 Origin;

    private bool found;

    private double diagMag;


    // Use this for initialization

    void setVals()
    {
        
        
    }

    void budder(int diameter)
    {
        Origin = new Vector3(0, 0, 0);
        numRows = diameter / 2;
        int count = 0;
        if (diameter != 0)
        {
            //check left
            //Left create
            GameObject hex = (GameObject)Instantiate(Hex);
            hex.transform.position = Origin;
            hex.GetComponent<HexMapGen>().budder(diameter, numRows, count);

            //instantiate a new object
            //set transform to 
        }



    }









    // Use this for initialization
    void Start () {
        
        budder(31);
	}
	

}
