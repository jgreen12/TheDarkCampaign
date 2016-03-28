using UnityEngine;
using System.Collections;

public class HexMapGen : MonoBehaviour {

    public GameObject Hex;
    public GameObject DLhex;
    public GameObject Lhex;
    public GameObject ULhex;
    public GameObject URhex;
    public GameObject Rhex;
    public GameObject DRhex;







    public int radius;
    public float hexWidth;
    public float hexHeight;


    private Vector3 LD;
    private Vector3 L;
    private Vector3 LU;
    private Vector3 RU;
    private Vector3 R;
    private Vector3 RD;
    
    public bool DLF;
    public bool LF;
    public bool ULF;
    public bool URF;
    public bool RF;
    public bool DRF;


	// Use this for initialization
	
    void setVals()
    {
        hexWidth = Hex.GetComponent<Renderer>().bounds.size.x;
        hexHeight = Hex.GetComponent<Renderer>().bounds.size.z;
        L = new Vector3(this.transform.position.x - hexWidth, this.transform.position.y, this.transform.position.z);
        LU = new Vector3(this.transform.position.x - (hexWidth/2), this.transform.position.y, this.transform.position.z + ((hexHeight/4)+(hexHeight/2)));
        LD = new Vector3(this.transform.position.x - (hexWidth / 2), this.transform.position.y, this.transform.position.z - ((hexHeight / 4) + (hexHeight / 2)));
        //R = new Vector3(this.transform.position.x + hexWidth, this.transform.position.y, this.transform.position.z);

        RU = new Vector3(this.transform.position.x + (hexWidth / 2), this.transform.position.y, this.transform.position.z + ((hexHeight / 4) + (hexHeight / 2)));
        RD = new Vector3(this.transform.position.x + (hexWidth / 2), this.transform.position.y, this.transform.position.z - ((hexHeight / 4) + (hexHeight / 2)));
        DLF = false;
        LF = false;
        ULF = false;
        URF = false;
        RF = false;
        DRF = false;
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
                //Vector3 zPos = new Vector3(0, 0, this.transform.position.z);
                //Vector3 oper;
                //oper = newPos * x;
                //oper = oper + zPos;
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











/*
    public void budDL(int r)
    {
        radius = r;
        setVals();
        checkLoc();
        if (!DLF && radius != 0)
        {
            GameObject DLhex = (GameObject)Instantiate(Hex);
            DLhex.transform.position = LD;
            DLhex.GetComponent<HexMapGen>().budDL(radius - 1);
        }
    }
    public void budL(int r)
    {
        radius = r;
        setVals();
        checkLoc();
        if (!LF && radius != 0)
        {
            GameObject Lhex = (GameObject)Instantiate(Hex);
            Lhex.transform.position = L;            
            Lhex.GetComponent<HexMapGen>().budL(radius - 1);
        }
    }
    public void budUL(int r)
    {
        radius = r;
        setVals();
        checkLoc();
        if (!ULF && radius != 0)
        {
            GameObject ULhex = (GameObject)Instantiate(Hex);
            ULhex.transform.position = LU;
            ULhex.GetComponent<HexMapGen>().budUL(radius - 1);
        }
    }
    public void budUR(int r)
    {
        radius = r;
        setVals();
        checkLoc();
        if (!URF && radius != 0)
        {
            GameObject URhex = (GameObject)Instantiate(Hex);
            URhex.transform.position = RU;
            URhex.GetComponent<HexMapGen>().budUR(radius - 1);
        }
    }
    public void budR(int r)
    {
        radius = r;
        setVals();
        checkLoc();
        if (!RF && radius != 0)
        {
            GameObject Rhex = (GameObject)Instantiate(Hex);
            Rhex.transform.position = R;
            Rhex.GetComponent<HexMapGen>().budR(radius - 1);
        }
    }
    public void budDR(int r)
    {
        radius = r;
        setVals();
        checkLoc();
        if (!RF && radius != 0)
        {
            GameObject DRhex = (GameObject)Instantiate(Hex);
            DRhex.transform.position = RD;
            DRhex.GetComponent<HexMapGen>().budDR(radius - 1);
        }
    }*/



/*    public void budder(int radius, int count)
    {
       /* bool dlc = false;   //bool values to see if object created
        bool lc = false;
        bool ulc = false;
        bool urc = false;
        bool rc = false;
        bool drc = false; */

        
        









    /*    if(radius != 0)
        {
           
            setVals();
            checkLoc(); */






          /*  if (!DLF)
            {
                GameObject DLhex = (GameObject)Instantiate(Hex);
                DLhex.transform.position = LD;
                DLhex.GetComponent<HexMapGen>().budDL(radius - 1);
            }
            if (!LF)
            {
                GameObject Lhex = (GameObject)Instantiate(Hex);
                Lhex.transform.position = L;
                Lhex.GetComponent<HexMapGen>().budL(radius - 1);
            }
            if (!ULF)
            {
                GameObject ULhex = (GameObject)Instantiate(Hex);
                ULhex.transform.position = LU;
                ULhex.GetComponent<HexMapGen>().budUL(radius - 1);
            }
            if (!URF)
            {
                GameObject URhex = (GameObject)Instantiate(Hex);
                URhex.transform.position = RU;
                URhex.GetComponent<HexMapGen>().budUR(radius - 1);
            }
            if (!RF)
            {
                GameObject Rhex = (GameObject)Instantiate(Hex);
                Rhex.transform.position = R;
                Rhex.GetComponent<HexMapGen>().budR(radius - 1);
            }
            if (!DRF)
            {
                GameObject DRhex = (GameObject)Instantiate(Hex);
                DRhex.transform.position = RD;
                DRhex.GetComponent<HexMapGen>().budDR(radius - 1);
            }*/



            /*            if (!DLF)
                        {
                            GameObject DLhex = (GameObject)Instantiate(Hex);
                            DLhex.transform.position = LD;
                            this.DLhex = DLhex;
                            dlc = true;
                            //DLhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }

                        //checkLoc();
                        if (!LF)
                        {
                            GameObject Lhex = (GameObject)Instantiate(Hex);
                            Lhex.transform.position = L;
                            this.Lhex = Lhex;

                            lc = true;
                            //Lhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }
                       // checkLoc();
                        if (!ULF)
                        {
                            GameObject ULhex = (GameObject)Instantiate(Hex);
                            ULhex.transform.position = LU;
                            this.ULhex = ULhex;
                            ulc = true;
                            //ULhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }

                        //checkLoc();
                        if (!URF)
                        {
                            GameObject URhex = (GameObject)Instantiate(Hex);
                            URhex.transform.position = RU;
                            this.URhex = URhex;
                            urc = true;
                            //URhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }
                        //checkLoc();
                        if (!RF){
                            GameObject Rhex = (GameObject)Instantiate(Hex);
                            Rhex.transform.position = R;
                            this.Rhex = Rhex;
                            rc = true;
                            //Rhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }
                        //checkLoc();
                        if (!DRF)
                        {
                            GameObject DRhex = (GameObject)Instantiate(Hex);
                            DRhex.transform.position = RD;
                            this.DRhex = DRhex;
                            drc = true;
                            //DRhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }


                        if (dlc)
                        {
                            DLhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }

                        if (lc)
                        {

                            Lhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }

                        if (ulc)
                        {

                            ULhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }


                        if (urc)
                        {

                            URhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }

                        if (rc)
                        {

                            Rhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }

                        if (drc)
                        {

                            DRhex.GetComponent<HexMapGen>().budder(radius - 1);
                        }*/

       // }



   // }

    void checkLoc()
    {
        GameObject[] eTiles;
        eTiles = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tile in eTiles)
        {
            if (tile.transform.position == LD)
            {
                DLF = true;
            }
            if (tile.transform.position == L)
            {
                LF = true;
            }
            if(tile.transform.position == LU)
            {
                ULF = true;
            }
            if (tile.transform.position == RU)
            {
                URF = true;
            }
            if (tile.transform.position == R)
            {
                RF = true;
            }
            if (tile.transform.position == RD)
            {
                DRF = true;
            }
            

        }
    }






}
