// EvenIC++.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//C++은 순차 프로그램
#include <iostream>
using namespace std;
//
//int func1(int N)
//{
//    int ret = 0;
//    for (int i = 1; i <= N; i++)
//    {
//        if (i % 3 == 0 || i % 5 == 0)ret += i;
//    }
//    return ret;
//}
//int func2(int arr[], int N)//1,52,48 n=3의 맞게 하기
//{
//    for (int i = 0; i < N; i++)
//        for (int j = i + 1; j < N; j++)
//            if (arr[i] + arr[j] == 100)return 1;
//    return 0;
//}

int func2(int arr[], int N)
{
    for (int i = 0; i < N; i++)
        for (int j = i + 1; j < N; j++)
            if (arr[i] + arr[j] == 100)return 1;
}

void test2()
{
    cout << "***** func2 test *******\n";
    int arr[3][4] = { {1,52,48},{50,42},{4,13,63,87} };
    int n[3] = { 3,2,4 };
    int ans[3] = { 1,0,1 };
    for (int i = 0; i < 3; i++)
    {
        int result = func2(arr[i], n[i]);
        cout << "TC #" << i << '\n';
        cout << "expected : " << ans[i] << " result :" << result;
        if (ans[i] == result)cout << "...Correct!\n";
        else cout << "...Wrong!\n";
    }
}
//void test1()
//{
//    cout << "*****fun1 test *******\n";
//    int n[3] = { 16,34567,27639 };
//    int ans[3] = { 60,278812814,178254968 };
//    int result = 0;
//    for (int i = 0; i < 3; i++)
//    {
//        result = func1(n[i]);
//        cout << "TC #" << i << '\n';
//        cout << "expected : " << ans[i] << " result : " << result;
//        if (ans[i] == result) cout << "...Correct!\n";
//        else cout << "...wrong\n";
//    }
//    cout << "******************************\n\n";
//        
//}

int main()
{
    //test1();
    test2();
}