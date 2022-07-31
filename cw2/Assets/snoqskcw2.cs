using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snoqskcw2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "greg";
        int heroAge = 2;
        int heroHeight = 4;
        string heroSuperPower = "friendship";

        string villainName = "za warudo";
        int villainAge = 100;
        int villainHeight = 10;
        string villainSuperPower = "the dark side of the force";

        int ageDifference = 100 - 2;


        print("I am " + heroName + " and I am " + heroAge + " years old. " + " I am also " + heroHeight + " feet tall." + " I will use the power of " + heroSuperPower + " to save you. ");
        print("I am " + villainName + " and I am " + villainAge + " years old. " + " I am also " + villainHeight + " feet tall." + " I will use " + villainSuperPower + " to destroy you all. ");
        print("Between " + heroName + " and " + villainName + " there is a " + ageDifference + " year difference.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
