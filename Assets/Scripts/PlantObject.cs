using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plant", menuName ="Plant")]

public class PlantObject : ScriptableObject
{
    public string plantName;
    public Sprite[] plantStages;
    public float timeBtwStages;
    public int buyPrice;
    public int sellPrice;
    public Sprite icon;
    public Sprite dryPlanted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
