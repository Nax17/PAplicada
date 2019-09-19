using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Puzzle
{
    public enum Estado
    {
        Menu,
        Iniciado,
        Terminado
    }
    public class Juego
    {
        public Estado EstadoActual { get; set; }
        public int[,] Board { get; set; }
    }
    class Program
    {
        static Thread _input;
        public static Juego JuegoActual;
        public static void IniciarJuego()
        {
            JuegoActual = new Juego();
            JuegoActual.Board = new int[3, 3];
            JuegoActual.EstadoActual = Estado.Menu;
            _input = new Thread(GetInput);
            _input.Start();
        }
        static void Main(string[] args)
        {
            IniciarJuego();
            while(JuegoActual.EstadoActual != Estado.Terminado)
            {
                switch (JuegoActual.EstadoActual)
                {
                    case Estado.Menu:
                        Menu();
                        break;
                    case Estado.Iniciado:
                        Board();
                        break;
                }
                Thread.Sleep(10);
            }
            GameOver();
        }
        static void GameOver()
        {
            _input.Abort();
            _input.Join();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("HOLA!");
            Console.WriteLine("Presione '1' para iniciar.");
            Console.WriteLine("Presione cualquier otra tecla para salir.");
        }
        static void Board()
        {
            int[] tmpBoard = new int[9];
            Random random = new Random(9);
            int tmp = random.Next();
            bool c;
            tmpBoard[0] = tmp;
            for(int i = 1; i < 9; i++)
            {
                c = checkExiste(tmpBoard, tmp);
                if(c == false)
                {
                    tmpBoard[i] = tmp;
                }
            }
            bool checkExiste(int[] t1, int t2)
            {
                for(int j = 0; j < 9; j++)
                {
                    if (t1[j] == t2)
                    {
                        return true;
                    }
                }
                return false;
            }
            Console.Clear();
            Console.WriteLine(tmpBoard[0] + tmpBoard[1] + tmpBoard[2] + "\n" + tmpBoard[3] + tmpBoard[4] + tmpBoard[5] + "\n" + tmpBoard[6] + tmpBoard[7] + tmpBoard[8]);

        }
        static void GetInput()
        {
            string _currentInput;
            while (true)
            {
                switch (JuegoActual.EstadoActual)
                {
                    case Estado.Menu:
                        _currentInput = Console.ReadKey().ToString();
                        JuegoActual.EstadoActual = _currentInput == "1" ? Estado.Iniciado : Estado.Iniciado;
                        break;
                    case Estado.Iniciado:
                        _currentInput = Console.ReadKey().ToString();

                        break;
                }
            }
        }
    }
}
