using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public static class sampleArray
{
    //variables
    private static int[] foo;
    private static bool c;
    private static int worms;
    private static int love;
    private static Text questionTextBox;
    private static Text resultTextBox;
    private static Text op1TextBox;
    private static Text op2TextBox;
    private static Text op3TextBox;
    private static GameObject fishButton;
    private static GameObject questionBox;
    private static GameObject resultBox;
    //sets game question scenarios.
    private static question q1 = new question(1, "Your son feels a little sad that he's struggling to fish.", 
        "\"You can do it, try this!\"",
        "\"You'll catch one next time...\"",
        "\"Any-fin is possible!\"",
        "You show your son a trick for how to cast his reel farther, he tries it out hapily.",
        "Your son seems unconvinced.",
        "Your son giggles and moves on.");
    private static question q2 = new question(2, "Your fishing line gets entangled with your son's...", 
        "Laugh and pull the lines in to undo the knot.", 
        "\"Keep yer line outta mine boy.\"", 
        "\"I'm fishin' for kids!\"",
        "Your son leans in to help you untangle it. You bond a little.",
        "Your son seems a little intimidated, he says \"Sorry dad...\".",
        "Your son blushes and looks out towards the lake.");
    private static question q3 = new question(3, "You pull out a bucket of worms to use as bait.", 
        "Ask your son if he wants to hook the worm.", 
        "Make your son hook the worm.", 
        "Hook the worm yourself.",
        "Your son says \"Thanks dad, I don't like worms.\".",
        "Your son's eyes water, it seems like he really didn't want to touch the live bait...",
        "Your son complains that he doesn't want to touch the live bait so you hook the worm for him.");
    private static question q4 = new question(4, "Another family floats by in a fishing boat.", 
        "Wave and say hi.", 
        "Show off by casting your line with exaggeration.", 
        "Ignore them.",
        "Your son joins in and waves as well~.",
        "Your son seems embarassed, he slouches to hide.",
        "You both continue to sit in silence.");
    private static question q5 = new question(5, "You catch a fish and your son doesn't seem to care.", 
        "Make the fish talk.", 
        "Show him how to gut a fish!", 
        "Let him hold the fish.",
        "Your son laughs. \"Good one dad.\"",
        "You cut open the fish and find an egg sack. Your son's eyes darken. It was a mom.",
        "Your son holds the fish with a blank expression.");
    private static question q6 = new question(6, "Your son is absently staring at the water and you get a mischievous urge.", 
        "Sneakily put a worm in his shirt.", 
        "Give him a playful shove.", 
        "Tickle him.",
        "Your son giggles. \"Ewwww!\"",
        "Oops, you shove your son a little too hard and he falls into the water. \nYou dive in to save him. \nHe comes out shivering cold.",
        "Your son stares at you. He's a little weirded out.");
    private static question q7 = new question(7, "You catch the BIG one. Your son sympathizes with the fish and wants to release it.", 
        "Release the fish.", 
        "Don't be a pussy.", 
        "Give him a long talk about the circle of life. It's sink or swim, kid.",
        "You slowly coax the fish back into the water. Be free, little guy. \nYour son looks satisfied.",
        "Your son gives you a frightened look and quickly goes back to minding his own business.",
        "Your son seems to understand and says \"We all have to eat.\"");
    private static question q8 = new question(8, "Your son reels in an old boot.", 
        "Pull the boot in.", 
        "Throw the boot back.", 
        "Put the boot on.",
        "You find a one hundred dollar bill in the boot. Yay!",
        "Your son looks sad. He wanted the boot.",
        "Your foot gets really wet and smells like algae. \nYou throw the boot back into the water having not accomplished anything.");
    private static question q9 = new question(9, "Your son mutters under his breath, \"This is lame...\"", 
        "\"We never get to spend time together any more... I miss us.\"", 
        "\"Son, you're going to fish and you're going to like it.\"", 
        "\"We'll head back in a bit.\"",
        "Your son gives you a hug.",
        "Your son gives you an annoyed look and inches away from you.",
        "You continue to sit in silence.");
    private static question q10 = new question(10, "You peer deep into the waters reflection, it shows your son, and yourself together...\nYour son watches you intently.", 
        "Smile lovingly towards your son.", 
        "Grunt at the scene.", 
        "Drop some money in the water (it may bring you luck while fishing).",
        "Your son blushes and looks away.",
        "Your son looks offended.",
        "Your son throws a few pennies in too.");
    private static question q11 = new question(11, "q11", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q12 = new question(12, "q12", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q13 = new question(13, "q13", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q14 = new question(14, "q14", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q15 = new question(15, "q15", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q16 = new question(16, "q16", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q17 = new question(17, "q17", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q18 = new question(18, "q18", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q19 = new question(19, "q19", "op1", "op2", "op3", "res1", "res2", "res3");
    private static question q20 = new question(20, "q20", "op1", "op2", "op3", "res1", "res2", "res3");
    public static question[] questions = { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20 };

    //setter methods
    public static void setArray(int[] a) { foo = a; }
    public static void setBool(bool a) { c = a; }
    public static void setWorms(int a) { worms = a; }
    public static void setLove(int a) { love = a; }
    public static void setQuestionTextBox(Text a) { questionTextBox = a; }
    public static void setResultTextBox(Text a) { resultTextBox = a; }
    public static void setop1TextBox(Text a) { op1TextBox = a; }
    public static void setop2TextBox(Text a) { op2TextBox = a; }
    public static void setop3TextBox(Text a) { op3TextBox = a; }
    public static void setFishButton(GameObject a) { fishButton = a; }
    public static void setQuestionBox(GameObject a) { questionBox = a; }
    public static void setResultBox(GameObject a) { resultBox = a; }
    //getters
    public static Text getQuestionTextBox() { return questionTextBox; }
    public static Text getResultTextBox() { return resultTextBox; }
    public static Text getop1TextBox() { return op1TextBox; }
    public static Text getop2TextBox() { return op2TextBox; }
    public static Text getop3TextBox() { return op3TextBox; }
    public static bool getBool() {  return c; }
    public static int[] getArray() { return foo; }
    public static int getLove() { return love; }
    public static int getworms() { return worms; }
    public static void turnFBoff() { fishButton.SetActive(false); }
    public static void turnFBon() { fishButton.SetActive(true); }
    public static void turnQBoff() { questionBox.SetActive(false); }
    public static void turnQBon() { questionBox.SetActive(true); }
    public static void turnRBoff() { resultBox.SetActive(false); }
    public static void turnRBon() { resultBox.SetActive(true); }

    public static void wormloss()
    {
        int w = getworms();
        w = w - 1;
        setWorms(w);
    }

    public static void heartGain()
    {
        int x = 0;
        x = getLove() + 10;
        if (x >= 100)
        {
            setLove(100);
        }
        else
        {
            setLove(x);
        }
    }

    public static void heartLoss()
    {
        int x = 0;
        x = getLove() - 10;
        if (x <= 0)
        {
            setLove(0);
        }
        else
        {
            setLove(x);
        }
    }

    //Question picker.
    public static question scenario()
    {
        //picks an index in foo.
        int index = Random.Range(0, getArray().Length-1);
        //this is the question ref No.
        int randNu=0;
        //sets the value of foo[index] to be random Number
        for(int j=0; j < getArray().Length; j++)
        {
            if(index == j)
            {
                randNu = getArray()[j];
            }
        }
        //resets foo without the chosen foo[index].
        int[] nufoo = new int[getArray().Length-1];
        int y = 0;
        for(int p = 0; p < getArray().Length; p++)
        {
            if(randNu != foo[p])
            {
                nufoo[y] = foo[p];
                y++;
            }
        }
        //sets overal question pool to not have the question index just found.
        setArray(nufoo);

        question thisOne = null;
        for(int i=0; i < questions.Length; i++)
        {
            if (randNu == questions[i].getrefNo())
            {
                thisOne = questions[i];
            }
        }
        return thisOne;  
    }
}
