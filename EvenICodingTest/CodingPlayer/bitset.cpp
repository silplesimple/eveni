#include<iostream>
#include<bitset>
#include<string>

using namespace std;

int main()
{
	bitset<32> decimal_to_binary(10);
	bitset<32> binary_to_decimal("1011");
	unsigned num = static_cast<unsigned>(binary_to_decimal.to_ulong());
	string binary_string = decimal_to_binary.to_string();

	size_t first_found = binary_string.find('1');
	if (first_found != string::npos)
		binary_string = binary_string.substr(first_found);

	cout << "10 to binary: " <<binary_string << "\n";
	cout << "1011 to decimal: " << num << '\n';
}