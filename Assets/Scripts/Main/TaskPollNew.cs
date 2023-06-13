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
        new TaskOption { optionName = "Option 1", money = 10000f,knowledge=0.1f,happy=-0.08f, explanation = "Congratulations! You have chosen a good job in the Israeli hi-tech field! The salary is high, but know that there are long working hours and the work can continue even into home and family time." },
        new TaskOption { optionName = "Option 2", money = 6000f,knowledge=0.02f,happy=0.03f, explanation = "Nice !! I think you did well, although the salary is average, but in this job there is a good balance between work and home and family life" },
        new TaskOption { optionName = "Option 3", money = 3000f,knowledge=0.01f,happy=0.08f, explanation = "You chose to go with your heart! I understand that you are a man of dreams, the salary is low, but without a doubt you will get to work in the things you like the most and want to achieve" }
            });

        tasks.Add("You are planning to buy a new car. Option 1 is an expensive luxury car with a price tag of $80,000 but provides a smooth and comfortable ride. Option 2 is a mid-range car priced at $40,000 with decent features. Option 3 is an economical car priced at $20,000, which offers good fuel efficiency.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -200000f,knowledge=-0.1f,happy=0.08f, explanation = "Renew! I understand that fuel costs and maintenance are not a problem for you.. You decided to buy one of the luxury vehicles available on the market, you are guaranteed a high-quality and quiet ride but at extremely high costs" },
        new TaskOption { optionName = "Option 2", money = -80000f,knowledge=0.8f,happy=0.04f, explanation = "Wow what a good opportunity! You chose to go for a good company and a medium car with decent features" },
        new TaskOption { optionName = "Option 3", money = -20000f,knowledge=0.1f,happy=-0.08f, explanation = "You probably like spending time in the garage... you chose to buy a cheap car in a problematic condition, what starts cheap can sometimes end up being expensive" }
            });

        tasks.Add("You have a sum of money and want to invest it in assets. Option 1 is to invest in real estate, which has the potential for long-term growth. Option 2 is to invest in stocks, which can yield high returns but also carry risks. Option 3 is to invest in a business, which offers the opportunity for entrepreneurship and control over your investment.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 5000f,knowledge=0.8f,happy=0.04f, explanation = "invest in real estate with long-term growth potential, invest a large amount of money and you will receive a large return accordingly" },
        new TaskOption { optionName = "Option 2", money = -8000f,knowledge=0.8f,happy=0.01f, explanation = "Oh, you are brave! You chose to invest in shares with high return potential but also with risks" },
        new TaskOption { optionName = "Option 3", money = 1000f,knowledge=0.2f,happy=0.05f, explanation = "I understand that you are a solid person... you chose to invest in a business for entrepreneurship and control, a low investment and profits accordingly" }
            });
        // Task 4
        tasks.Add("You have some money to invest in the stock market. Option 1 is to invest in a tech company, which has been experiencing rapid growth. Option 2 is to invest in a pharmaceutical company, which is developing a promising drug. Option 3 is to invest in a renewable energy company, which is poised to benefit from the transition to clean energy.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 7000f, explanation = "Invest in a tech company with rapid growth potential" },
        new TaskOption { optionName = "Option 2", money = -4000f, explanation = "Invest in a pharmaceutical company with a promising drug" },
        new TaskOption { optionName = "Option 3", money = 6000f, explanation = "Invest in a renewable energy company benefiting from clean energy transition" }
            });

        // Task 5
        tasks.Add("You have the opportunity to support an environmental cause. Option 1 is to donate to a wildlife conservation organization. Option 2 is to volunteer for a beach cleanup event. Option 3 is to participate in a tree-planting initiative.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -2000f,knowledge=0.2f,happy=0.01f, explanation = "Thank you very much for your generous donation, we will be happy to see you next time with us on Volunteer Day" },
        new TaskOption { optionName = "Option 2", money = -1000f,knowledge=0.3f,happy=0.05f, explanation = "Inspiring! Thank you for giving your money and energy to donate and volunteer for at-risk youth" },
        new TaskOption { optionName = "Option 3", money = 0f,knowledge=0.1f,happy=0.02f, explanation = "Thank you for your participation in the tree planting initiative" }
            });

        // Task 6
        tasks.Add("Your family wants to go on a vacation. Option 1 is to plan an extravagant trip to an exotic location. Option 2 is to have a budget-friendly vacation at a nearby destination. Option 3 is to have a staycation and explore local attractions.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -10000f,knowledge=0.1f,happy=0.06f, explanation = "This is going to be fun!!! You chose a luxury vacation, your dream trip is about to embark on an extravagant trip to an exotic location," },
        new TaskOption { optionName = "Option 2", money = -5000f,knowledge=0.5f,happy=0.03f, explanation = "You chose to go on a great vacation in a great location and comfort and all this on sale! We are sure you will enjoy it" },
        new TaskOption { optionName = "Option 3", money = -2000f,knowledge=0.1f,happy=0.01f, explanation = "You have chosen a field stay and explore local attractions" }
            });

        // Task 7
        tasks.Add("You have been offered a promotion at work. Option 1 is to accept the promotion and take on more responsibilities for a higher salary. Option 2 is to decline the promotion and focus on work-life balance. Option 3 is to negotiate the terms of the promotion to achieve a better work-life balance.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 8000f,knowledge=0.1f,happy=-0.08f, explanation = "Congratulations! You received a significant promotion and an upgrade in salary, now most of the responsibility is in your hands" },
        new TaskOption { optionName = "Option 2", money = 0f,knowledge=0.04f,happy=0.04f, explanation = "Interesting, you decided to start negotiations to see if it is possible to move forward but in a more gradual way that suits the nature of your life" },
        new TaskOption { optionName = "Option 3", money = 5000f, knowledge=0.01f,happy=0.08f, explanation = "You decided to reject the job offer and stay in the same position that is convenient for you, the familiar and the well-known" }
            });

        // Task 8
        tasks.Add("You have the opportunity to learn a new skill but You must decide between learning a hobby or learning something that will add to your salary. Option 1 is to learn a programming language. Option 2 is to learn a musical instrument. Option 3 is to learn a foreign language.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 3000f,knowledge=0.2f,happy=-0.08f, explanation = "It's definitely not your hobby but it will surely add to your salary, you chose to learn a programming language" },
        new TaskOption { optionName = "Option 2", money = 2000f,knowledge=0.1f,happy=0.4f, explanation = "Wow that sounds amazing! You went with your heart and your talent chose to learn a musical instrument" },
        new TaskOption { optionName = "Option 3", money = 2500f,knowledge=0.4f,happy=0.08f, explanation = "Great idea ! You also like to know languages and this can also help and upgrade your work. You chose to learn a foreign language" }
            });

        // Task 9
        tasks.Add("You have the opportunity to join a gym. Option 1 is to join a traditional gym with a variety of equipment. Option 2 is to join a specialized fitness studio focusing on a specific workout style. Option 3 is to create a home gym with basic equipment.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -1000f,knowledge=0.3f,happy=0.2f, explanation = "tough! You chose to follow the most difficult route. You chose to join the intense training of Crossfit. A traditional gym with a variety of equipment. The cost is high, but you will certainly see results." },
        new TaskOption { optionName = "Option 2", money = -500f,knowledge=0.4f,happy=0.4f, explanation = "Well done! You chose to join a special fitness studio that focuses on a specific training style that is both healthy and at fair prices, the best and correct way to keep your body healthy" },
        new TaskOption { optionName = "Option 3", money = 0f,knowledge=0.1f,happy=0.08f, explanation = "That's how you don't progress and get results, you chose to give up regular training and just create a home gym with basic equipment" }
            });

        // Task 10
        tasks.Add("You have the opportunity to take up a new hobby. Option 1 is to start painting or drawing. Option 2 is to start gardening. Option 3 is to start cooking or baking.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 1500f, explanation = "Start painting or drawing" },
        new TaskOption { optionName = "Option 2", money = 1000f, explanation = "Start gardening" },
        new TaskOption { optionName = "Option 3", money = 1200f, explanation = "Start cooking or baking" }
            });

        // Task 11
        tasks.Add("You have the opportunity to donate to a charity. Option 1 is to donate to a children's education charity. Option 2 is to donate to a disaster relief organization. Option 3 is to donate to a healthcare foundation.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -1500f, explanation = "Donate to a children's education charity" },
        new TaskOption { optionName = "Option 2", money = -1000f, explanation = "Donate to a disaster relief organization" },
        new TaskOption { optionName = "Option 3", money = -1200f, explanation = "Donate to a healthcare foundation" }
            });

        // Task 12
        tasks.Add("You have the opportunity to adopt a pet. Option 1 is to adopt a dog. Option 2 is to adopt a cat. Option 3 is to adopt a small mammal or bird.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -2000f, explanation = "Adopt a dog" },
        new TaskOption { optionName = "Option 2", money = -1500f, explanation = "Adopt a cat" },
        new TaskOption { optionName = "Option 3", money = -1000f, explanation = "Adopt a small mammal or bird" }
            });

        // Task 13
        tasks.Add("You have the opportunity to travel to a new destination. Option 1 is to visit a historical city. Option 2 is to relax on a tropical beach. Option 3 is to explore a natural wonder.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -3000f, explanation = "Visit a historical city" },
        new TaskOption { optionName = "Option 2", money = -2500f, explanation = "Relax on a tropical beach" },
        new TaskOption { optionName = "Option 3", money = -2800f, explanation = "Explore a natural wonder" }
            });

        // Task 14
        tasks.Add("You have the opportunity to enroll in a professional course. Option 1 is to take a business management course. Option 2 is to take a digital marketing course. Option 3 is to take a graphic design course.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -1500f, explanation = "Take a business management course" },
        new TaskOption { optionName = "Option 2", money = -1000f, explanation = "Take a digital marketing course" },
        new TaskOption { optionName = "Option 3", money = -1200f, explanation = "Take a graphic design course" }
            });

        // Task 15
        tasks.Add("You have the opportunity to volunteer for a cause. Option 1 is to volunteer at a local animal shelter. Option 2 is to volunteer at a community center. Option 3 is to volunteer for an environmental organization.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 1000f, explanation = "Volunteer at a local animal shelter" },
        new TaskOption { optionName = "Option 2", money = 800f, explanation = "Volunteer at a community center" },
        new TaskOption { optionName = "Option 3", money = 900f, explanation = "Volunteer for an environmental organization" }
            });

        // Task 16
        tasks.Add("You have the opportunity to invest in the stock market. Option 1 is to invest in technology stocks. Option 2 is to invest in healthcare stocks. Option 3 is to invest in energy stocks.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -2000f, explanation = "Invest in technology stocks" },
        new TaskOption { optionName = "Option 2", money = -1500f, explanation = "Invest in healthcare stocks" },
        new TaskOption { optionName = "Option 3", money = -1800f, explanation = "Invest in energy stocks" }
            });

        // Task 17
        tasks.Add("You have the opportunity to start a blog or YouTube channel. Option 1 is to focus on lifestyle and fashion. Option 2 is to focus on technology and gadgets. Option 3 is to focus on travel and adventure.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 500f, explanation = "Focus on lifestyle and fashion" },
        new TaskOption { optionName = "Option 2", money = 400f, explanation = "Focus on technology and gadgets" },
        new TaskOption { optionName = "Option 3", money = 450f, explanation = "Focus on travel and adventure" }
            });

        // Task 18
        tasks.Add("You have the opportunity to join a book club. Option 1 is to join a classic literature book club. Option 2 is to join a science fiction book club. Option 3 is to join a mystery and thriller book club.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 800f, explanation = "Join a classic literature book club" },
        new TaskOption { optionName = "Option 2", money = 700f, explanation = "Join a science fiction book club" },
        new TaskOption { optionName = "Option 3", money = 750f, explanation = "Join a mystery and thriller book club" }
            });

        // Task 19
        tasks.Add("You have the opportunity to start a meditation or mindfulness practice. Option 1 is to practice meditation daily. Option 2 is to attend mindfulness workshops or retreats. Option 3 is to use a meditation app or guided meditation resources.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = 600f, explanation = "Practice meditation daily" },
        new TaskOption { optionName = "Option 2", money = 500f, explanation = "Attend mindfulness workshops or retreats" },
        new TaskOption { optionName = "Option 3", money = 550f, explanation = "Use a meditation app or guided meditation resources" }
            });

        // Task 20
        tasks.Add("You have the opportunity to invest in a startup. Option 1 is to invest in a technology startup with a disruptive product. Option 2 is to invest in a healthcare startup focusing on innovative treatments. Option 3 is to invest in a sustainable living startup promoting eco-friendly products.",
            new List<TaskOption>
            {
        new TaskOption { optionName = "Option 1", money = -5000f, explanation = "Invest in a technology startup with a disruptive product" },
        new TaskOption { optionName = "Option 2", money = 4000f, explanation = "Invest in a healthcare startup focusing on innovative treatments" },
        new TaskOption { optionName = "Option 3", money = 3000f, explanation = "Invest in a sustainable living startup promoting eco-friendly products" }
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
                option1.setVal(op1.money, op1.knowledge, op1.happy);
                option2.setVal(op2.money, op2.knowledge, op2.happy);
                option3.setVal(op3.money, op3.knowledge, op3.happy);
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
    public float money = 0f;
    public float knowledge = 0f;
    public float happy = 0f;
    public string explanation;
}
