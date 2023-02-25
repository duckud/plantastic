using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotManager : MonoBehaviour
{
    bool isPlanted = false;
    public SpriteRenderer plant;

    public Sprite[] plantStages;
    int plantStage = 0;
    float timeBtwStages = 2f;
    float timer; 


    // Start is called before the first frame update
    void Start()
    {
        if (isPlanted)
        {
            time -= Time.deltaTime;

            if (timer < 0 && plantStage <= plantStages.Length -1 )
            {
                timer = timeBtwStages;
                plantStage++;
                UpdatePlant();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (isPlanted)
        {
            Harvest();
        }
        else
        {
            Plant();
        }

        Debug.Log("Clicked");
    }

    void Harvest()
    {
        Debug.Log("Harvested");
        isPlanted = false;
        plant.gameObject.setActive(false);

    }

    void Plant()
    {
        Debug.Log("Planted");
        isPlanted = true;
        plantStage = 0; 
        UpdatePlant();
        timer = timeBtwStages;
        plant.gameObject.setActive(true);
    }

    void UpdatePlant()
    {
        plant.sprite = plantStages[plantStage];
    }
}
