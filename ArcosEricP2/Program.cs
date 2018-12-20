using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcosEricP2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Control de Versiones");

			vectorInicializar();
			
			Console.ReadKey();
		}
		public static void vectorInicializar()
		{
			int[] x = new int[100];
			x[0] = 1;
			x[1] = 2;
			x[2] = 3;
			x[3] = 4;
			x[4] = 5;
			x[5] = 6;
			x[6] = 7;
			x[8] = 8;
			x[9] = 20;
			x[10] = 21;
			x[11] = 23;
			x[12] = 22;
			x[13] = 10;
			x[14] = 11;
			x[15] = 12;
			x[16] = 16;
			x[17] = 17;
			x[18] = 18;
			x[19] = 19;
			x[20] = 24;
			x[21] = 26;
			x[22] = 25;
			x[23] = 27;
			x[24] = 29;
			x[25] = 28;
			x[26] = 30;
			x[27] = 32;
			x[28] = 31;
			x[29] = 33;
			x[30] = 35;
			x[31] = 34;
			x[32] = 36;
			x[33] = 37;
			x[34] = 38;
			x[35] = 39;
			x[36] = 40;
			x[37] = 41;
			x[38] = 42;
			x[39] = 43;
			x[40] = 44;
			x[41] = 46;
			x[42] = 45;
			x[43] = 47;
			x[44] = 48;
			x[45] = 49;
			x[46] = 50;
			x[47] = 51;
			x[48] = 52;
			x[49] = 53;
			x[50] = 54;
			x[51] = 55;
			x[52] = 56;
			x[53] = 57;
			x[54] = 58;
			x[55] = 59;
			x[56] = 60;
			x[57] = 61;
			x[58] = 62;
			x[59] = 63;
			x[60] = 64;
			x[61] = 65;
			x[62] = 66;
			x[63] = 67;
			x[64] = 68;
			x[65] = 69;
			x[66] = 70;
			x[67] = 71;
			x[68] = 72;
			x[69] = 73;
			x[70] = 74;
			x[71] = 75;
			x[72] = 76;
			x[73] = 77;
			x[74] = 78;
			x[75] = 79;
			x[76] = 80;
			x[77] = 81;
			x[78] = 82;
			x[79] = 84;
			x[80] = 85;
			x[81] = 83;
			x[82] = 86;
			x[83] = 87;
			x[84] = 88;
			x[85] = 89;
			x[86] = 90;
			x[87] = 91;
			x[88] = 92;
			x[89] = 93;
			x[90] = 94;
			x[91] = 95;
			x[92] = 96;
			x[93] = 97;
			x[94] = 98;
			x[95] = 99;
			x[96] = 100;
			x[97] = 101;
			x[98] = 102;
			x[99] = 103;
	
			
			//////////
			//imprimir el vector
			Console.WriteLine("\nELEMENTOS DEL VECTOR\n=============\n");
			for (int i = 0; i < x.Length; i++)
			{
				Console.WriteLine("Elemento índice {0} -->{1}", (i + 1), x[i]);
			}
			//sumatoria de los elementos del vector
			int vmax = x[99];
			int vmin = x[0];

			int suma = 0;
			for (int i = 0; i < x.Length; i++)
			{
				suma = suma + x[i];
				vmax = x[99];
				vmin = x[0];
			}
		
			Console.WriteLine("La sumatoria es {0}", suma);
			Console.WriteLine("El promedio es {0}", suma / x.Length);
			Console.WriteLine("Valor Maximo es {0}", vmax);
			Console.WriteLine("Valor Minimo es {0} ", vmin);
		

		}

		


		

		}
	}

