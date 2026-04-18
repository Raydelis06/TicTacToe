using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Models;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool finalizada = false;
        bool enTurno = true;
        bool esGanador = false;

        Jugador jugador;
        string jugadorMaquina;

        //0 - vacio, 1 - jugador, 2 - maquina
        int[,] tablero = new int[3, 3];
        Button[,] celdas;
        public Form1()
        {
            InitializeComponent();
            jugador = new Jugador();
            jugarDeNuevo();
            jugadorMaquina = "C:\\Users\\Raydelis Hilario\\source\\repos\\TicTacToe\\Resources\\o.png";
            celdas = new Button[3, 3] {
                { c1f1, c2f1, c3f1 },
                { c1f2, c2f2, c3f2 },
                { c1f3, c2f3, c3f3 }
            };
            LabelPuntaje.Text = jugador.puntuacion.ToString();
        }
        //columna 1
        private void c1f1_Click(object sender, EventArgs e)
        {
            if (tablero[0,0] == 0 && enTurno)
            {
                c1f1.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[0, 0] = 1;
                pasarTurnoMaquinaAsync();
            }
            else
            {
                panelAviso.Visible = true;
            }
        }
        private void c1f2_Click(object sender, EventArgs e)
        {
            if (tablero[1, 0] == 0 && enTurno)
            {
                c1f2.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[1, 0] = 1;
                pasarTurnoMaquinaAsync();

            }
            else
            {
                panelAviso.Visible = true;
            }
        }
        private void c1f3_Click(object sender, EventArgs e)
        {
            if (tablero[2, 0] == 0 && enTurno)
            {
                c1f3.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[2, 0] = 1;
                pasarTurnoMaquinaAsync();
            }
            else
            {
                panelAviso.Visible = true;
            }

        }
        //columna 2
        private void c2f1_Click(object sender, EventArgs e)
        {
            if (tablero[0, 1] == 0 && enTurno)
            {
                c2f1.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[0, 1] = 1;
                pasarTurnoMaquinaAsync();
            }
            else
            {
                panelAviso.Visible = true;
            }
        }
        private void c2f2_Click(object sender, EventArgs e)
        {
            if (tablero[1, 1] == 0 && enTurno)
            {
                c2f2.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[1, 1] = 1;
                pasarTurnoMaquinaAsync();
            }
            else
            {
                panelAviso.Visible = true;
            }

        }
        private void c2f3_Click(object sender, EventArgs e)
        {
            if (tablero[2, 1] == 0 && enTurno)
            {
                c2f3.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[2, 1] = 1;
                pasarTurnoMaquinaAsync();
            }
            else
            {
                panelAviso.Visible = true;
            }
        }
        //columna 3
        private void c3f1_Click(object sender, EventArgs e)
        {
            if (tablero[0, 2] == 0)
            {
                c3f1.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[0, 2] = 1;
                pasarTurnoMaquinaAsync();

            }
            else
            {
                panelAviso.Visible = true;
            }
        }
        private void c3f2_Click(object sender, EventArgs e)
        {
            if (tablero[1, 2] == 0)
            {
                c3f2.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[1, 2] = 1;
                pasarTurnoMaquinaAsync();

            }
            else
            {
                panelAviso.Visible = true;
            }

        }
        private void c3f3_Click(object sender, EventArgs e)
        {
            if (tablero[2, 2] == 0)
            {
                c3f3.BackgroundImage = Image.FromFile(jugador.rutaImagen);
                tablero[2, 2] = 1;
                pasarTurnoMaquinaAsync();

            }
            else
            {
                panelAviso.Visible = true;
            }
        }

        private void limpiarTablero()
        {
            c1f1.BackgroundImage = null;
            c1f2.BackgroundImage = null;
            c1f3.BackgroundImage = null;
            c2f1.BackgroundImage = null;
            c2f2.BackgroundImage = null;
            c2f3.BackgroundImage = null;
            c3f1.BackgroundImage = null;
            c3f2.BackgroundImage = null;
            c3f3.BackgroundImage = null;

            tablero = new int[3, 3];
            esGanador = false;
            finalizada = false;
            enTurno = true;
        }
        private void finJuego(bool esGanador)
        {
            if(esGanador == true)
            {
                jugador.puntuacion += 20;
                LabelPuntaje.Text = jugador.puntuacion.ToString();
                panelAviso.Visible = true;
                labelAviso.Text = "¡Felicidades!";
            }
            else
            {
                panelAviso.Visible = true;
                labelAviso.Text = "Has perdido";
            }
        }
        private void jugarDeNuevo()
        {
            limpiarTablero();
            jugador.rutaImagen = "C:\\Users\\Raydelis Hilario\\source\\repos\\TicTacToe\\Resources\\x.png";
            jugadorActual.Image = Image.FromFile(jugador.rutaImagen);
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            panelAviso.Visible = false;
            if(finalizada)
            {
                jugarDeNuevo();
            }
        }
        private async Task pasarTurnoMaquinaAsync()
        {
            enTurno = false;
            await Task.Delay(300);
            jugadorActual.Image = Image.FromFile(jugadorMaquina);
            evaluarFinJuego();
            if(finalizada)
            {
                finJuego(esGanador);
                return;
            }
            await Task.Delay(2000);
            generarJugada();
            await Task.Delay(300);

            jugadorActual.Image = Image.FromFile(jugador.rutaImagen);
            evaluarFinJuego();
            if (finalizada)
            {
                finJuego(esGanador);
                return ;
            }
            enTurno = true;

        }
        private void generarJugada()
        {
            Random random = new Random();
            int fila = 0;
            int columna = 0;
            do
            {
                fila = random.Next(0, 3);
                columna = random.Next(0, 3);
            } while (tablero[fila, columna] != 0 && !finalizada);
            tablero[fila, columna] = 2;

            celdas[fila, columna].BackgroundImage = Image.FromFile(jugadorMaquina);

        }
        private void evaluarFinJuego()
        {
            // 1. Evaluar Filas y Columnas
            for (int i = 0; i < 3; i++)
            {
                // Filas
                if (tablero[i, 0] != 0 && tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2])
                {
                    finalizada = true;
                    esGanador = (tablero[i, 0] == 1);
                    return; // Salimos si ya hay ganador
                }
                // Columnas
                if (tablero[0, i] != 0 && tablero[0, i] == tablero[1, i] && tablero[1, i] == tablero[2, i])
                {
                    finalizada = true;
                    esGanador = (tablero[0, i] == 1);
                    return;
                }
            }

            // 2. Evaluar Diagonales (fuera del bucle)
            if (tablero[1, 1] != 0) // Si el centro está vacío, ninguna diagonal sirve
            {
                if ((tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2]) ||
                    (tablero[0, 2] == tablero[1, 1] && tablero[1, 1] == tablero[2, 0]))
                {
                    finalizada = true;
                    esGanador = (tablero[1, 1] == 1);
                }
            }
        }
        // 0 0 0
        // 0 0 0
        // 0 0 0
    }
}
