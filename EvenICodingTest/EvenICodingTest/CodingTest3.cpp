#include <string>
#include <iostream>
using namespace std;

bool solution(string s)
{    
    bool answer = true;
    int pCount = 0;
    int yCount = 0;
    for (int i = 0; i < s.length(); i++)
    {
        if (s[i] == 'p' || s[i] == 'P')
        {
            pCount += 1;
        }
        else if (s[i] == 'y' || s[i] == 'Y')
        {
            yCount += 1;
        }        
    }
    if (pCount + yCount == 0 || pCount == yCount)
    {
        answer = true;
    }
    else
    {
        answer = false;
    }
    return answer;
}
bool solution1(string s)
{
    int p = 0;
    int y = 0;
    for (int i = 0; i < s.size(); i++)
    {
        if (s[i] == 'p' || s[i] == 'P')
        {
            p++;
        }
        else if(s[i]=='y'||s[i]=='Y')
        {
            y++;
        }
    }
    return p==y;
}
int main()
{
    //cout<< boolalpha<<solution("pPoooyY");
    cout << boolalpha << solution1("yY4554pP");
}