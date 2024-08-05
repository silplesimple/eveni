
using namespace std;
#include <iostream>



void insert(int idx, int num, int arr[], int& len)
{
    for (int i = len; i > idx; i--) 
    {
        arr[i] = arr[i - 1];
        arr[idx] = num;
        len++;
    }
    
}

void erase(int idx, int arr[], int& len)
{
    len--;
    for (int i = idx; i < len; i++)
    {
        arr[i] = arr[i + 1];
    }
}

void printArr(int arr[], int& len)
{
    for (int i = 0; i < len; i++)cout << arr[i] << ' ';
    cout << "\n\n";
}

void insert_test()
{
    cout << "*****insert_test*****\n";
    int arr[10] = { 10,50,40,30,70,20 };
    int len = 6;
    insert(3, 60, arr, len); // 10 20 30 40
   
}

void erase_test()
{
    cout << "*****erase_test*****\n";
    int arr[10] = { 10,50,40,30,70,20 };
    int len = 6;
    erase(4, arr, len);
    printArr(arr, len);
    
}
int main()
{
    insert_test();
    erase_test();

    int a[21];
    int b[21][21];

    // 1. memset
    memset(a, 2, sizeof a);
    memset(b, 2, sizeof b);

    for (int i = 0; i < 21; i++)
    {
        a[i] = 0;
    }
    for (int i = 0; i < 21; i++)
    {
        for (int j = 0; j < 21; j++)
            fill(b[i], b[i] + 21, 0);
        }
    }
}


