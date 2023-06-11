using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class TaskPollNew : MonoBehaviour
{
    public Text text;
    private Dictionary<string, List<TaskOption>> tasks = new Dictionary<string, List<TaskOption>>();
    private string text_str;

    [SerializeField] selected option1;
    [SerializeField] selected option2;
    [SerializeField] selected option3;
    void Awake()
    {
        // Task 1


        tasks.Add("You have been offered a new job opportunity. Option 1 offers a high salary of $10,000 per month but requires long working hours. Option 2 provides a moderate salary of $6,000 per month with a good work-life balance. Option 3 offers a low salary of $3,000 per month but involves working on your dream project.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 10000f, explanation = "High salary with long working hours" },
        new TaskOption { optionName = "Option 2", value = 6000f, explanation = "Moderate salary with good work-life balance" },
        new TaskOption { optionName = "Option 3", value = 3000f, explanation = "Low salary, but working on your dream project" }
            });

        tasks.Add("You are planning to buy a new car. Option 1 is an expensive luxury car with a price tag of $80,000 but provides a smooth and comfortable ride. Option 2 is a mid-range car priced at $40,000 with decent features. Option 3 is an economical car priced at $20,000, which offers good fuel efficiency.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -80000f, explanation = "Expensive luxury car with a smooth and comfortable ride" },
        new TaskOption { optionName = "Option 2", value = 40000f, explanation = "Mid-range car with decent features" },
        new TaskOption { optionName = "Option 3", value = 20000f, explanation = "Economical car with good fuel efficiency" }
            });

        tasks.Add("You have a sum of money and want to invest it in assets. Option 1 is to invest in real estate, which has the potential for long-term growth. Option 2 is to invest in stocks, which can yield high returns but also carry risks. Option 3 is to invest in a business, which offers the opportunity for entrepreneurship and control over your investment.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 5000f, explanation = "Invest in real estate with long-term growth potential" },
        new TaskOption { optionName = "Option 2", value = -8000f, explanation = "Invest in stocks with high return potential but also risks" },
        new TaskOption { optionName = "Option 3", value = 3000f, explanation = "Invest in a business for entrepreneurship and control" }
            });
        // Task 4
        tasks.Add("You have some money to invest in the stock market. Option 1 is to invest in a tech company, which has been experiencing rapid growth. Option 2 is to invest in a pharmaceutical company, which is developing a promising drug. Option 3 is to invest in a renewable energy company, which is poised to benefit from the transition to clean energy.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 7000f, explanation = "Invest in a tech company with rapid growth potential" },
        new TaskOption { optionName = "Option 2", value = -4000f, explanation = "Invest in a pharmaceutical company with a promising drug" },
        new TaskOption { optionName = "Option 3", value = 6000f, explanation = "Invest in a renewable energy company benefiting from clean energy transition" }
            });

        // Task 5
        tasks.Add("You have the opportunity to support an environmental cause. Option 1 is to donate to a wildlife conservation organization. Option 2 is to volunteer for a beach cleanup event. Option 3 is to participate in a tree-planting initiative.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -2000f, explanation = "Donate to a wildlife conservation organization" },
        new TaskOption { optionName = "Option 2", value = 1000f, explanation = "Volunteer for a beach cleanup event" },
        new TaskOption { optionName = "Option 3", value = 1500f, explanation = "Participate in a tree-planting initiative" }
            });

        // Task 6
        tasks.Add("Your family wants to go on a vacation. Option 1 is to plan an extravagant trip to an exotic location. Option 2 is to have a budget-friendly vacation at a nearby destination. Option 3 is to have a staycation and explore local attractions.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -10000f, explanation = "Plan an extravagant trip to an exotic location" },
        new TaskOption { optionName = "Option 2", value = 5000f, explanation = "Have a budget-friendly vacation at a nearby destination" },
        new TaskOption { optionName = "Option 3", value = 2000f, explanation = "Have a staycation and explore local attractions" }
            });

        // Task 7
        tasks.Add("You have been offered a promotion at work. Option 1 is to accept the promotion and take on more responsibilities for a higher salary. Option 2 is to decline the promotion and focus on work-life balance. Option 3 is to negotiate the terms of the promotion to achieve a better work-life balance.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 8000f, explanation = "Accept the promotion and take on more responsibilities for a higher salary" },
        new TaskOption { optionName = "Option 2", value = 0f, explanation = "Decline the promotion and focus on work-life balance" },
        new TaskOption { optionName = "Option 3", value = 5000f, explanation = "Negotiate the terms of the promotion for a better work-life balance" }
            });

        // Task 8
        tasks.Add("You have the opportunity to learn a new skill. Option 1 is to learn a programming language. Option 2 is to learn a musical instrument. Option 3 is to learn a foreign language.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 3000f, explanation = "Learn a programming language" },
        new TaskOption { optionName = "Option 2", value = 2000f, explanation = "Learn a musical instrument" },
        new TaskOption { optionName = "Option 3", value = 2500f, explanation = "Learn a foreign language" }
            });

        // Task 9
        tasks.Add("You have the opportunity to join a gym. Option 1 is to join a traditional gym with a variety of equipment. Option 2 is to join a specialized fitness studio focusing on a specific workout style. Option 3 is to create a home gym with basic equipment.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -1000f, explanation = "Join a traditional gym with a variety of equipment" },
        new TaskOption { optionName = "Option 2", value = -500f, explanation = "Join a specialized fitness studio focusing on a specific workout style" },
        new TaskOption { optionName = "Option 3", value = 0f, explanation = "Create a home gym with basic equipment" }
            });

        // Task 10
        tasks.Add("You have the opportunity to take up a new hobby. Option 1 is to start painting or drawing. Option 2 is to start gardening. Option 3 is to start cooking or baking.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 1500f, explanation = "Start painting or drawing" },
        new TaskOption { optionName = "Option 2", value = 1000f, explanation = "Start gardening" },
        new TaskOption { optionName = "Option 3", value = 1200f, explanation = "Start cooking or baking" }
            });

        // Task 11
        tasks.Add("You have the opportunity to donate to a charity. Option 1 is to donate to a children's education charity. Option 2 is to donate to a disaster relief organization. Option 3 is to donate to a healthcare foundation.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -1500f, explanation = "Donate to a children's education charity" },
        new TaskOption { optionName = "Option 2", value = -1000f, explanation = "Donate to a disaster relief organization" },
        new TaskOption { optionName = "Option 3", value = -1200f, explanation = "Donate to a healthcare foundation" }
            });

        // Task 12
        tasks.Add("You have the opportunity to adopt a pet. Option 1 is to adopt a dog. Option 2 is to adopt a cat. Option 3 is to adopt a small mammal or bird.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -2000f, explanation = "Adopt a dog" },
        new TaskOption { optionName = "Option 2", value = -1500f, explanation = "Adopt a cat" },
        new TaskOption { optionName = "Option 3", value = -1000f, explanation = "Adopt a small mammal or bird" }
            });

        // Task 13
        tasks.Add("You have the opportunity to travel to a new destination. Option 1 is to visit a historical city. Option 2 is to relax on a tropical beach. Option 3 is to explore a natural wonder.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -3000f, explanation = "Visit a historical city" },
        new TaskOption { optionName = "Option 2", value = -2500f, explanation = "Relax on a tropical beach" },
        new TaskOption { optionName = "Option 3", value = -2800f, explanation = "Explore a natural wonder" }
            });

        // Task 14
        tasks.Add("You have the opportunity to enroll in a professional course. Option 1 is to take a business management course. Option 2 is to take a digital marketing course. Option 3 is to take a graphic design course.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -1500f, explanation = "Take a business management course" },
        new TaskOption { optionName = "Option 2", value = -1000f, explanation = "Take a digital marketing course" },
        new TaskOption { optionName = "Option 3", value = -1200f, explanation = "Take a graphic design course" }
            });

        // Task 15
        tasks.Add("You have the opportunity to volunteer for a cause. Option 1 is to volunteer at a local animal shelter. Option 2 is to volunteer at a community center. Option 3 is to volunteer for an environmental organization.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 1000f, explanation = "Volunteer at a local animal shelter" },
        new TaskOption { optionName = "Option 2", value = 800f, explanation = "Volunteer at a community center" },
        new TaskOption { optionName = "Option 3", value = 900f, explanation = "Volunteer for an environmental organization" }
            });

        // Task 16
        tasks.Add("You have the opportunity to invest in the stock market. Option 1 is to invest in technology stocks. Option 2 is to invest in healthcare stocks. Option 3 is to invest in energy stocks.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -2000f, explanation = "Invest in technology stocks" },
        new TaskOption { optionName = "Option 2", value = -1500f, explanation = "Invest in healthcare stocks" },
        new TaskOption { optionName = "Option 3", value = -1800f, explanation = "Invest in energy stocks" }
            });

        // Task 17
        tasks.Add("You have the opportunity to start a blog or YouTube channel. Option 1 is to focus on lifestyle and fashion. Option 2 is to focus on technology and gadgets. Option 3 is to focus on travel and adventure.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 500f, explanation = "Focus on lifestyle and fashion" },
        new TaskOption { optionName = "Option 2", value = 400f, explanation = "Focus on technology and gadgets" },
        new TaskOption { optionName = "Option 3", value = 450f, explanation = "Focus on travel and adventure" }
            });

        // Task 18
        tasks.Add("You have the opportunity to join a book club. Option 1 is to join a classic literature book club. Option 2 is to join a science fiction book club. Option 3 is to join a mystery and thriller book club.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 800f, explanation = "Join a classic literature book club" },
        new TaskOption { optionName = "Option 2", value = 700f, explanation = "Join a science fiction book club" },
        new TaskOption { optionName = "Option 3", value = 750f, explanation = "Join a mystery and thriller book club" }
            });

        // Task 19
        tasks.Add("You have the opportunity to start a meditation or mindfulness practice. Option 1 is to practice meditation daily. Option 2 is to attend mindfulness workshops or retreats. Option 3 is to use a meditation app or guided meditation resources.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = 600f, explanation = "Practice meditation daily" },
        new TaskOption { optionName = "Option 2", value = 500f, explanation = "Attend mindfulness workshops or retreats" },
        new TaskOption { optionName = "Option 3", value = 550f, explanation = "Use a meditation app or guided meditation resources" }
            });

        // Task 20
        tasks.Add("You have the opportunity to invest in a startup. Option 1 is to invest in a technology startup with a disruptive product. Option 2 is to invest in a healthcare startup focusing on innovative treatments. Option 3 is to invest in a sustainable living startup promoting eco-friendly products.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", value = -5000f, explanation = "Invest in a technology startup with a disruptive product" },
        new TaskOption { optionName = "Option 2", value = 4000f, explanation = "Invest in a healthcare startup focusing on innovative treatments" },
        new TaskOption { optionName = "Option 3", value = 3000f, explanation = "Invest in a sustainable living startup promoting eco-friendly products" }
            });
        // Shuffle the task list
        ShuffleTasks();


    }

    private void ShuffleTasks()
    {
        List<KeyValuePair<string, List<TaskOption>>> taskList = new List<KeyValuePair<string, List<TaskOption>>>(tasks);

        System.Random random = new System.Random();

        int n = taskList.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            KeyValuePair<string, List<TaskOption>> temp = taskList[k];
            taskList[k] = taskList[n];
            taskList[n] = temp;
        }

        tasks = new Dictionary<string, List<TaskOption>>();
        foreach (var task in taskList)
        {
            tasks.Add(task.Key, task.Value);
        }
    }

    public void GetRandomTask()
    {
        int randomIndex = UnityEngine.Random.Range(0, tasks.Count);
        int currentIndex = 0;

        foreach (var task in tasks)
        {
            if (currentIndex == randomIndex)
            {
                text_str = task.Key;
                var options = task.Value;

                TaskOption op1 = options[0];
                TaskOption op2 = options[1];
                TaskOption op3 = options[2];
                option1.setVal(op1.value);
                option2.setVal(op3.value);
                option3.setVal(op3.value);
                option1.setEx(op1.explanation);
                option2.setEx(op2.explanation);
                option3.setEx(op3.explanation);
            }

            currentIndex++;
        }
    }
    void Update()
    {
        text.text = text_str;
    }
    public void setText(string new_text)
    {
        text_str = new_text;
    }
}
public class TaskOption
{
    public string optionName;
    public float value;
    public string explanation;
}
