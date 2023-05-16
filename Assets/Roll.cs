using System.Collections;
using UnityEngine;

public class Roll : MonoBehaviour
{

   

    private int currectVal = 1;

    private bool rolling = false;
    private float rollingDuration = 2f;
    private float rollingTimer = 0f;
    private float rollingSpeed = 500f;
    private Vector3 rollingDirection;
    private int result = 0;

    void Update()
    {
        if (rolling)
        {
            rollingTimer += Time.deltaTime;

            if (rollingTimer >= rollingDuration)
            {

                rolling = false;
                if(result == 1)
                {
                    transform.rotation = Quaternion.Euler(270,0,0);
                }
                else if (result == 2)
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else if (result == 3)
                {
                    transform.rotation = Quaternion.Euler(0, 0, 270);
                }
                else if (result == 4)
                {
                    transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else if (result == 5)
                {
                    transform.rotation = Quaternion.Euler(180, 0, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(90, 0, 0);
                }
                // Show the final result on the dice face
                Debug.Log("Result: " + result);
                currectVal = result;
            }
            else
            {
                transform.Rotate(rollingDirection, rollingSpeed * Time.deltaTime);
            }
        }
    }

    // Coroutine that rolls the dice
    public IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        rolling = true;
        rollingTimer = 0f;
        result = Random.Range(1, 7);
        // Generate a random direction for the rolling animation

        rollingDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        yield return new WaitForSeconds(2f);

        /*int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        int finalSide = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 5);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
        finalSide = randomDiceSide + 1;

        // Show final dice value in Console
        Debug.Log(finalSide);

        currectVal = finalSide;*/
    }

    public int getVal()
    {
        return currectVal;
    }
}
