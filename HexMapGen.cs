using UnityEngine;
using System.Collections;

public class HexMapGen : MonoBehaviour {

    public GameObject Hex;
    public float hexWidth;
    public float hexHeight;
    private Vector3 RU;
    private Vector3 RD;


	// Use this for initialization
	
    void setVals()
    {
        hexWidth = Hex.GetComponent<Renderer>().bounds.size.x;
        hexHeight = Hex.GetComponent<Renderer>().bounds.size.z;
        RU = new Vector3(this.transform.position.x + (hexWidth / 2), this.transform.position.y, this.transform.position.z + ((hexHeight / 4) + (hexHeight / 2)));
        RD = new Vector3(this.transform.position.x + (hexWidth / 2), this.transform.position.y, this.transform.position.z - ((hexHeight / 4) + (hexHeight / 2)));

    }


    public void budder(int diameter, int numRows, int count)
    {
        if (numRows >= 0)
        {
            setVals();
            for (int x = 1; x < (diameter - count); x++)
            {
                GameObject Rhex = (GameObject)Instantiate(Hex);
                Vector3 newPos = new Vector3(this.transform.position.x + (x*hexWidth), this.transform.position.y, this.transform.position.z);
                Rhex.transform.position = newPos;

            }
            if (numRows != 0)
            {
                GameObject UHex = (GameObject)Instantiate(Hex);
                UHex.transform.position = RU;
                UHex.GetComponent<HexMapGen>().budder(diameter, numRows - 1, count + 1);
                GameObject DHex = (GameObject)Instantiate(Hex);
                DHex.transform.position = RD;
                DHex.GetComponent<HexMapGen>().budder(diameter, numRows - 1, count + 1);

            }
        }

    }
    






}
