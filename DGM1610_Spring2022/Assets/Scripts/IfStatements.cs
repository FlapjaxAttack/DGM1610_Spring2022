using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    //public string lightColor;

    //public string weather;

    public string hairColor;

    public int age;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(lightColor == "Red")
         {
             Debug.Log("The light is " + lightColor + ", STOP!!!!")
         }
         else if(lightColor == "Yellow")
         {
             Debug.Log("The light is " + lightColor + ", hold your horses there!")
         }
         else if (lightColor == "Yellow")
         {
             Debug.Log("The light is " + lightColor + ", GO GO GO!!!!")
         }
         else
         {
             Debug.Log("COLOR ERROR")
         }

         if(weather == "Rain" || weather == "Snow")
         {
             Debug.Log("the weather is shoddy, wear a fetching coat!");
         }
         else if(weather == "Sunny" || weather = = "Partly Cloudy")
         {
             Debug.Log("No coat needed, thanks!");
         }
        */
        if (hairColor == "Red" && age == 6)
        {
            Debug.Log("You can't ride this ride, Little Mister!");
        }
        else if (hairColor == "Blonde" && age == 100)
        {
            Debug.Log("Sit down and enjoy the ride, sire.");
        }


    }
}
