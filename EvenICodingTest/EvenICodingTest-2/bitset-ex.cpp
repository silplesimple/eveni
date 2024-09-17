#include<iostream>
#include<string>

using namespace std;

int get_binary(int n)
{
	int result;
	string binary = "";

	while (n != 0)
	{
		binary += to_string(n % 2);
		n /= 2;
	}

	reverse(binary.begin(), binary.end());

	result=stoi(binary);
	return result;
}

//int get_decimal(string n)
//{
//	int decimal = 0;
//	int factor = n.size();
//
//	for (const auto& ch : n)
//	{
//		decimal += (ch - '0') * pow(2, --factor);
//	}
//
//	return decimal;
//}

int get_decimal(string n)
{
	int decimal = 0;

	for (const auto& ch : n)
	{
		decimal <<= 1;

		if (ch == '1')
			decimal += 1;
	}

	return decimal;
}

int main()
{
	int result;
	string decimal = "1010";
	result=get_binary(10);
	cout << result << '\n';
	result = get_decimal(decimal);
	cout << result << '\n';
}