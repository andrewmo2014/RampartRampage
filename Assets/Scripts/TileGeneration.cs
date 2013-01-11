using UnityEngine;
using System.Collections;

public class TileGeneration : MonoBehaviour {
    
    
    public enum TileType{
        SINGLE,
        DOUBLE,
        CORNER,
        Z_SHAPE,
        ZIG_ZAG,
        U_SHAPE,
        T_SHAPE,
        TRIPLE,
        S_SHAPE,
        L_SHAPE,
        J_SHAPE,
        CROSS
    }
    
    public TileType currentTile;
    

	// Use this for initialization
	void Start () {
        currentTile = TileType.SINGLE;	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
