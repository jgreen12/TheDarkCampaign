using UnityEngine;
using System.Collections;

public class HexGenOrigin : MonoBehaviour {

    public GameObject Hex;
    

    public float hexWidth;
    public float hexHeight;
    public int numRows;
    int diameter;
    Vector3 Origin;
    private Vector3 RU;
    private Vector3 RD;
    public int numTiles;


    // Use this for initialization

    void setVals()
    {
        numTiles = 0;
        diameter = 301;
        hexWidth = Hex.GetComponent<Renderer>().bounds.size.x;
        hexHeight = Hex.GetComponent<Renderer>().bounds.size.z;
        Origin = new Vector3(0, 0, 0);
        numRows = diameter / 2;

        RU = new Vector3(this.transform.position.x + (hexWidth / 2), this.transform.position.y, this.transform.position.z + ((hexHeight / 4) + (hexHeight / 2)));
        RD = new Vector3(this.transform.position.x + (hexWidth / 2), this.transform.position.y, this.transform.position.z - ((hexHeight / 4) + (hexHeight / 2)));

    }


    public void budder()
    {

        setVals();
        int count = 0;
        if (diameter != 0)
        {
            //check left
            //Left create
            GameObject hex = (GameObject)Instantiate(Hex);
            hex.transform.position = Origin;
            numTiles++;
            //instantiate a new object
            //set transform to 
        }




        if (numRows >= 0)
        {
            
            for (int x = 1; x < (diameter - count); x++)
            {
                GameObject Rhex = (GameObject)Instantiate(Hex);
                Vector3 newPos = new Vector3(this.transform.position.x + (x * hexWidth), this.transform.position.y, this.transform.position.z);
                Rhex.transform.position = newPos;
                numTiles++;
            }
            if (numRows != 0)
            {
                count = 0;
                for (int x = 1; x <= (numRows); x++)
                {
                    GameObject UHex = (GameObject)Instantiate(Hex);
                    Vector3 RU = new Vector3(this.transform.position.x + (x*(hexWidth / 2)), this.transform.position.y, this.transform.position.z + (x*((hexHeight / 4) + (hexHeight / 2))));
                    UHex.transform.position = RU;
                    count++;
                    numTiles++;
                    for(int y = 1; y < (diameter - count); y++)
                    {
                        GameObject Rhex = (GameObject)Instantiate(Hex);
                        Vector3 newPos = new Vector3(UHex.transform.position.x + (y * hexWidth), UHex.transform.position.y, UHex.transform.position.z);
                        Rhex.transform.position = newPos;
                        numTiles++;
                    }
                    
                }
                count = 0;
                for(int x = 1; x <= (numRows); x++)
                {
                    GameObject DHex = (GameObject)Instantiate(Hex);
                    Vector3 RD = new Vector3(this.transform.position.x + (x*(hexWidth / 2)), this.transform.position.y, this.transform.position.z - (x*((hexHeight / 4) + (hexHeight / 2))));
                    DHex.transform.position = RD;
                    count++;
                    numTiles++;
                    for (int y = 1; y < (diameter - count); y++)
                    {
                        GameObject Rhex = (GameObject)Instantiate(Hex);
                        Vector3 newPos = new Vector3(DHex.transform.position.x + (y * hexWidth), DHex.transform.position.y, DHex.transform.position.z);
                        Rhex.transform.position = newPos;
                        numTiles++;
                    }
                    
                }
                



                

            }
        }

    }











    // Use this for initialization
    void Start () {
        
        budder();
	}
	

}
