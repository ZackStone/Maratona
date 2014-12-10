// Aquecimento2014.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{

	string line;
	ifstream myfile ("volver.txt");
	if (myfile.is_open())
	{

		while ( getline (myfile,line) )
		{
			cout << line << '\n';
		}
		myfile.close();

		int count = 0;
		for (int i = 0; i < line.size(); i++)
		{
			if (line.substr(i, 1) == "E")
			{
				count --;
			}
			else if (line.substr(i, 1) == "D")
			{
				count ++ ;
			}
		}

		int direcao = count % 4;

		switch (direcao)
		{
		case 0:
			cout << "NORTE";
			break;
		case 1:
		case -3:
			cout << "LESTE";
			break;
		case 2:
		case -2:
			cout << "SUL";
			break;
		case 3:
		case -1:
			cout << "OESTE";
			break;
		default:
			break;
		}

	}

	else cout << "Unable to open file";


	return 0;
}

