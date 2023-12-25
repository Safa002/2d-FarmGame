using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public GameObject plantItem;
    private void Awake(){
        //Assets/Resources/Plants
        var loadPlants = Resources.LoadAll("Plants", typeof(PlantObject));
        foreach(var plant in loadPlants){
            PlantItem newPlant = Instantiate(plantItem, transform).GetComponent<PlantItem>();
            newPlant.plant = (PlantObject)plant;
        }
    }
}
