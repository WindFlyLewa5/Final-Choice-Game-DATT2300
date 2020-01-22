using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question
{
    private int refNo;
    private string scenario;
    private string option1;
    private string option2;
    private string option3;
    private string res1;
    private string res2;
    private string res3;
    
    public question(int a, string b)
    {
        setrefNo(a);
        setScenario(b);
    }
    public question(int a, string b, string c, string d, string e)
    {
        setrefNo(a);
        setScenario(b);
        setOption1(c);
        setOption2(d);
        setOption3(e);
    }
    public question(int a, string b, string c, string d, string e, string f, string g, string h)
    {
        setrefNo(a);
        setScenario(b);
        setOption1(c);
        setOption2(d);
        setOption3(e);
        setResult1(f);
        setResult2(g);
        setResult3(h);
    }
    public void setrefNo(int a) { refNo = a; }
    public void setScenario(string a) { scenario = a; }
    public void setOption1(string a) { option1 = a; }
    public void setOption2(string a) { option2 = a; }
    public void setOption3(string a) { option3 = a; }
    public void setResult1(string a) { res1 = a; }
    public void setResult2(string a) { res2 = a; }
    public void setResult3(string a) { res3 = a; }
    public int getrefNo() { return refNo; }
    public string getScenario() { return scenario; }
    public string getOption1() { return option1; }
    public string getOption2() { return option2; }
    public string getOption3() { return option3; }
    public string getResult1() { return res1; }
    public string getResult2() { return res2; }
    public string getResult3() { return res3; }
}
