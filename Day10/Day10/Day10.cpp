// Day10.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
using namespace std;

enum Superpowers
{
    Speed, Flight, Strength, Money, Swimming
};

void Print(Superpowers power)
{
    switch (power)
    {
    case Superpowers::Speed:
        break;
    case Flight:
        break;
    case Strength:
        break;
    case Money:
        break;
    case Swimming:
        break;
    default:
        break;
    }
}
int main()
{
    Superpowers powers = Superpowers::Swimming;
    Print(powers);
   
    //std - namespace
    //:: - scope resolution operator
    //cout - console output stream
    //<< - insertion operator. inserting characters into the output stream
    std::cout << "Hello Gotham!\n";
    cout << sizeof(char) << " (bytes)\n";

    int num = 5;

    char meh[] = "Aquaman";// \0 - null terminator
    char speedy[] = { 'F','l','a','s','h', '\0'};
    cout << meh << "\n";
    cout << speedy << "\n";

    int i = 0;
    while (true)
    {
        i++;
        if (i < 100) continue;

        break;
    }
    int numbers[] = { 1,2,3,4,5 };
    srand(time(NULL));//seed the random generator
    cout << RAND_MAX << "\n";
    for (int i = 0; i < 5; i++)
    {
        numbers[i] = rand();//0-RAND_MAX
        numbers[i] = rand() % 1001;//0-1000  % - modulus operator
        cout << numbers[i] << "\n";//Console.WriteLine(numbers[i]);
    }

    vector<int> scores;//calling the vector default constructor
    scores.push_back(rand());
    scores.push_back(rand());
    scores.push_back(rand());

    for (size_t i = 0; i < scores.size(); i++)
    {
        cout << scores[i] << "\n";
    }
}


// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
