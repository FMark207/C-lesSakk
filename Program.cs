namespace Rectangles
{
    //w vagy b
    //F = futó
    //L = ló
    //B = bástya
    //P = paraszt
    //V = vezér
    //K = király
    //pl. wF = fehér futó
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabla tabla = new Tabla();

            tabla.NewTable();
            tabla.DrawTable();

            string command = Console.ReadLine();
            while (command != null) {
                if (command[0] == 't')
                {
                    Console.WriteLine($"bástya üt: {hányat_üt_bástya(tabla, $"{command[1]}{command[2]}")}");
                }
                if (command[0] == 'k')
                {
                    Console.WriteLine($"futó üt: {hányat_üt_futó(tabla, $"{command[1]}{command[2]}")}");
                }
                if (command[0] == 'v')
                {
                    Console.WriteLine($"vezér üt: {hányat_üt_vezér(tabla, $"{command[1]}{command[2]}")}");
                }
                if (command[0] == 'n')
                {
                    tabla.table[int.Parse($"{command[1]}"), int.Parse($"{command[2]}")] = $"{command[3]}{command[4]}";
                    tabla.DrawTable();
                }
                command = Console.ReadLine();
            }
        }
        static int hányat_üt_bástya(Tabla Table, string kód)
        {
            int count = 0;
            int row = kód[0] == 'a' ? 0 : kód[0] == 'b' ? 1 : kód[0] == 'c' ? 2 : kód[0] == 'd' ? 3 : kód[0] == 'e' ? 4 : kód[0] == 'f' ? 5 : kód[0] == 'g' ? 6 : 7;
            int col = int.Parse($"{kód[1]}") - 1;
            string pawn = Table.Table[row, col];
            if (pawn == "" || !pawn.Contains("B")) return 0;
            for ( int i = col + 1; i < 8; i++)
            {
                if (Table.Table[row, i] == "  ") continue;
                if(Table.Table[row, i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for ( int i = col - 1; i > 0; i--)
            {
                if (Table.Table[row, i] == "  ") continue;
                if(Table.Table[row, i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for ( int i = row + 1; i < 8; i++)
            {
                if (Table.Table[i, col] == "  ") continue;
                if (Table.Table[i, col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for ( int i = row - 1; i > 0; i--)
            {
                if (Table.Table[i, col] == "  ") continue;
                if(Table.Table[i, col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            return count;
            
        }
        static int hányat_üt_futó(Tabla Table, string kód)
        {
            int count = 0;
            int row = kód[0] == 'a' ? 0 : kód[0] == 'b' ? 1 : kód[0] == 'c' ? 2 : kód[0] == 'd' ? 3 : kód[0] == 'e' ? 4 : kód[0] == 'f' ? 5 : kód[0] == 'g' ? 6 : 7;
            int col = int.Parse($"{kód[1]}") - 1;
            string pawn = Table.Table[row, col];
            if (pawn == "" || !pawn.Contains("F")) return 0;
            for (int i = 1; i + col < 8 && i + row < 8; i++)
            {
                if (Table.Table[i+row, i+col] == "  ") continue;
                if (Table.Table[i + row, i + col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; i + col < 8 && row - i > 0; i++)
            {
                if (Table.Table[row - 1, i + col] == "  ") continue;
                if (Table.Table[row - 1, i + col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; col - i > 0 && row + i < 8; i++)
            {
                if (Table.Table[row + 1, col - i] == "  ") continue;
                if (Table.Table[row + 1, col - i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; col - i > 0 && row - i > 0; i++)
            {
                if (Table.Table[row - i, col - i] == "  ") continue;
                if (Table.Table[row - i, col - i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            return count;

        }
        static int hányat_üt_huszár(Tabla Table, string kód)
        {
            int count = 0;
            int row = kód[0] == 'a' ? 0 : kód[0] == 'b' ? 1 : kód[0] == 'c' ? 2 : kód[0] == 'd' ? 3 : kód[0] == 'e' ? 4 : kód[0] == 'f' ? 5 : kód[0] == 'g' ? 6 : 7;
            int col = int.Parse($"{kód[1]}") - 1;
            string pawn = Table.Table[row, col];
            if (pawn == "" || !pawn.Contains("L")) return 0;
            for (int i = 1; i + col < 8 && i + row < 8; i++)
            {
                if (Table.Table[i + row, i + col] == "  ") continue;
                if (Table.Table[i + row, i + col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; i + col < 8 && row - i > 0; i++)
            {
                if (Table.Table[row - 1, i + col] == "  ") continue;
                if (Table.Table[row - 1, i + col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; col - i > 0 && row + i < 8; i++)
            {
                if (Table.Table[row + 1, col - i] == "  ") continue;
                if (Table.Table[row + 1, col - i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; col - i > 0 && row - i > 0; i++)
            {
                if (Table.Table[row - i, col - i] == "  ") continue;
                if (Table.Table[row - i, col - i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            return count;

        }
        static int hányat_üt_vezér(Tabla Table, string kód)
        {
            int count = 0;
            int row = kód[0] == 'a' ? 0 : kód[0] == 'b' ? 1 : kód[0] == 'c' ? 2 : kód[0] == 'd' ? 3 : kód[0] == 'e' ? 4 : kód[0] == 'f' ? 5 : kód[0] == 'g' ? 6 : 7;
            int col = int.Parse($"{kód[1]}") - 1;
            string pawn = Table.Table[row, col];
            if (pawn == "" || !pawn.Contains("V")) return 0;
            for (int i = 1; i + col < 8 && i + row < 8; i++)
            {
                if (Table.Table[i + row, i + col] == "  ") continue;
                if (Table.Table[i + row, i + col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; i + col < 8 && row - i > 0; i++)
            {
                if (Table.Table[row - 1, i + col] == "  ") continue;
                if (Table.Table[row - 1, i + col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; col - i > 0 && row + i < 8; i++)
            {
                if (Table.Table[row + 1, col - i] == "  ") continue;
                if (Table.Table[row + 1, col - i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = 1; col - i > 0 && row - i > 0; i++)
            {
                if (Table.Table[row - i, col - i] == "  ") continue;
                if (Table.Table[row - i, col - i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = col + 1; i < 8; i++)
            {
                if (Table.Table[row, i] == "  ") continue;
                if (Table.Table[row, i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = col - 1; i > 0; i--)
            {
                if (Table.Table[row, i] == "  ") continue;
                if (Table.Table[row, i].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = row + 1; i < 8; i++)
            {
                if (Table.Table[i, col] == "  ") continue;
                if (Table.Table[i, col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            for (int i = row - 1; i > 0; i--)
            {
                if (Table.Table[i, col] == "  ") continue;
                if (Table.Table[i, col].Contains(pawn[0] == 'w' ? 'b' : 'w'))
                {
                    count++;
                }
                break;
            }
            return count;

        }
    }
    public class Tabla
    {
        public string[,] table = new string[8, 8];

        public string[,] Table   // property
        {
            get { return table; }   // get method
           // set { table = value; }  // set method
        }

        public void NewTable()
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    table[i, j] = "  ";
                }
            }

            // Black Pawns

            for (int i = 0; i < 8; i++)
            {
                table[1, i] = "bP";
            }

            // White Pawns
            for (int i = 0; i < 8; i++)
            {
                table[6, i] = "wP";
            }

            // Black Rooks

            table[0, 0] = "bB";
            table[0, 7] = "bB";

            // White Rooks
            table[7, 0] = "wB";
            table[7, 7] = "wB";

            // Black Knights
            table[0, 1] = "bL";
            table[0, 6] = "bL";

            // Black Knights
            table[7, 1] = "wL";
            table[7, 6] = "wL";

            // Black Bishops
            table[0, 2] = "bF";
            table[0, 5] = "bF";

            // White Bishops
            table[7, 2] = "wF";
            table[7, 5] = "wF";

            // Black Queen
            table[0, 3] = "bV";

            // White Queen
            table[7, 3] = "wV";

            // Black King
            table[0, 4] = "bK";

            // White King
            table[7, 4] = "wK";


        }

        public void DrawTable()
        {
            int topPadding = 3;
            Console.SetCursorPosition(0, topPadding);

            int tableCycle = 0;
            Console.ForegroundColor = ConsoleColor.Black;

            for (int sor = 0; sor < 8; sor++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    if (tableCycle == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(table[sor, oszlop]);
                        tableCycle = 1;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Write(table[sor, oszlop]);
                        tableCycle = 0;
                    }
                }

                tableCycle = 1 - tableCycle;
                Console.WriteLine();
            }

            Console.ResetColor();
        }

        public void SaveTable()
        {

        }

    }
}
