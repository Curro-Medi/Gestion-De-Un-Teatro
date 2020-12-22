using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practica_4_teatro
{
    /// <summary>
    /// Lógica de interacción para Teatro.xaml
    /// </summary>
    public partial class Teatro : Window
    {
        MainWindow mw;
        Sala sala;
        List<Asientos> asientos;
        List<int> columnas = new List<int>();
        List<int> filas = new List<int>();
        Boolean compradooreservado;

        public Teatro()
        {
            InitializeComponent();
            
        }

        public Teatro(MainWindow mainWindow, Sala sala, List<Asientos> asientos)
        {
            InitializeComponent();
            this.mw = mainWindow;
            this.sala = sala;
            this.asientos = asientos;
                       
        }

        public Teatro(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mw = mainWindow;
       

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mw.Show();
            this.Hide();

        }

        private void c1f1_Click(object sender, RoutedEventArgs e)
        {
                        
            var elemento = (UIElement)e.Source;

                if(c1f1.Background != Brushes.LightBlue || c1f1.Background != Brushes.DarkOliveGreen || c1f1.Background != Brushes.Yellow)
                {
                    columnas.Add(Grid.GetColumn(elemento));
                    filas.Add(Grid.GetRow(elemento));
                }

            c1f1.Background = Brushes.LightBlue;

        }

        private void c2f1_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c2f1.Background != Brushes.LightBlue || c2f1.Background != Brushes.DarkOliveGreen || c2f1.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c2f1.Background = Brushes.LightBlue;


        }

        private void c3f1_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c3f1.Background != Brushes.LightBlue || c3f1.Background != Brushes.DarkOliveGreen || c3f1.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c3f1.Background = Brushes.LightBlue;

        }

        private void c4f1_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c4f1.Background != Brushes.LightBlue || c4f1.Background != Brushes.DarkOliveGreen || c4f1.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c4f1.Background = Brushes.LightBlue;

        }

        private void c1f2_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c1f2.Background != Brushes.LightBlue || c1f2.Background != Brushes.DarkOliveGreen || c1f2.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c1f2.Background = Brushes.LightBlue;

        }

        private void c2f2_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c2f2.Background != Brushes.LightBlue || c2f2.Background != Brushes.DarkOliveGreen || c2f2.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c2f2.Background = Brushes.LightBlue;

        }

        private void c3f2_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c3f2.Background != Brushes.LightBlue || c3f2.Background != Brushes.DarkOliveGreen || c3f2.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c3f2.Background = Brushes.LightBlue;

        }

        private void c4f2_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c4f2.Background != Brushes.LightBlue || c4f2.Background != Brushes.DarkOliveGreen || c4f2.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c4f2.Background = Brushes.LightBlue;
        }

        private void c1f3_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c1f3.Background != Brushes.LightBlue || c1f3.Background != Brushes.DarkOliveGreen || c1f3.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c1f3.Background = Brushes.LightBlue;

        }

        private void c2f3_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c2f3.Background != Brushes.LightBlue || c2f3.Background != Brushes.DarkOliveGreen || c2f3.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c2f3.Background = Brushes.LightBlue;
        }

        private void c3f3_Click(object sender, RoutedEventArgs e)
        {

            var elemento = (UIElement)e.Source;

            if (c3f3.Background != Brushes.LightBlue || c3f3.Background != Brushes.DarkOliveGreen || c3f3.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c3f3.Background = Brushes.LightBlue;

        }

        private void c4f3_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c4f3.Background != Brushes.LightBlue || c4f3.Background != Brushes.DarkOliveGreen || c4f3.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c4f3.Background = Brushes.LightBlue;

        }

        private void c1f4_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c1f4.Background != Brushes.LightBlue || c1f4.Background != Brushes.DarkOliveGreen || c1f4.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c1f4.Background = Brushes.LightBlue;
        }

        private void c2f4_Click(object sender, RoutedEventArgs e)
        {

            var elemento = (UIElement)e.Source;

            if (c2f4.Background != Brushes.LightBlue || c2f4.Background != Brushes.DarkOliveGreen || c2f4.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c2f4.Background = Brushes.LightBlue;

        }

        private void c3f4_Click(object sender, RoutedEventArgs e)
        {
            var elemento = (UIElement)e.Source;

            if (c3f4.Background != Brushes.LightBlue || c3f4.Background != Brushes.DarkOliveGreen || c3f4.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c3f4.Background = Brushes.LightBlue;

        }

        private void c4f4_Click(object sender, RoutedEventArgs e)
        {

            var elemento = (UIElement)e.Source;

            if (c4f4.Background != Brushes.LightBlue || c4f4.Background != Brushes.DarkOliveGreen || c4f4.Background != Brushes.Yellow)
            {
                columnas.Add(Grid.GetColumn(elemento));
                filas.Add(Grid.GetRow(elemento));
            }

            c4f4.Background = Brushes.LightBlue;

        }

        private void btncomprar_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < columnas.Count; i++)
            {
                asientos.Add(new Asientos(columnas[i], filas[i], "comprado"));
                for (int t = 0; t < asientos.Count; t++)
                {
                    if (asientos[t].Columna == columnas[i] && asientos[i].Fila == filas[t] && asientos[i].Estado.Equals("reservado"))
                    {
                        asientos.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                }
               

            }

            if (columnas.Count == 0 && filas.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningun asiento");
            }
            else
            {
                this.Hide();
                mw.Show();
            }

        }

        private void btnanularcompra_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < asientos.Count; i++)
            {
                for(int t = 0; t<columnas.Count; t++)
                {
                    if (asientos[i].Columna == columnas[t] && asientos[i].Fila == filas[t] && asientos[i].Estado.Equals("comprado"))
                    {
                        asientos.RemoveAt(i);
                    }
                }
                
            }
            if (columnas.Count == 0 && filas.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningun asiento");
            }
            else
            {
                this.Hide();
                mw.Show();
            }
        }

        private void reservar_Click(object sender, RoutedEventArgs e)
        {

                for (int i = 0; i < columnas.Count; i++)
                {
                    asientos.Add(new Asientos(columnas[i], filas[i], "reservado"));
                for (int t = 0; t < asientos.Count; t++)
                    {
                        if (asientos[t].Columna == columnas[i] && asientos[i].Fila == filas[t] && asientos[i].Estado.Equals("comprado"))
                        {
                            asientos.RemoveAt(i);
                    }
                    else
                    {
                        break;
                    }
                    }
                        
                               
                }
            if (columnas.Count == 0 && filas.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningun asiento");
            }
            else
            {
                this.Hide();
                mw.Show();
            }

        }

        private void btnanularreserva_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < asientos.Count; i++)
            {
                for (int t = 0; t < columnas.Count; t++)
                {
                    if (asientos[i].Columna == columnas[t] && asientos[i].Fila == filas[t] && asientos[i].Estado.Equals("reservado"))
                    {
                        asientos.RemoveAt(i);
                    }
                }

            }
            
            if(columnas.Count==0 && filas.Count == 0)
            {
                MessageBox.Show("No has seleccionado ningun asiento");
            }
            else
            {
                this.Hide();
                mw.Show();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

        }

        private void c1f1_Loaded(object sender, RoutedEventArgs e)
        {
           
                foreach (Asientos a in asientos)
                {
                    if (a.Estado.Equals("comprado") && a.Columna == 0 && a.Fila == 0)
                    {
                        c1f1.Background = Brushes.DarkOliveGreen;

                    }else if (a.Estado.Equals("reservado") && a.Columna == 0 && a.Fila == 0){
                
                        c1f1.Background = Brushes.Yellow;
                    }
                }
           
        }

        private void c2f1_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 1 && a.Fila == 0)
                {
                    c2f1.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 1 && a.Fila == 0)
                {
                    c2f1.Background = Brushes.Yellow;
                }
            }
        }

        private void c3f1_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 2 && a.Fila == 0)
                {
                    c3f1.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 2 && a.Fila == 0)
                {
                    c3f1.Background = Brushes.Yellow;
                }
            }
        }

        private void c4f1_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 3 && a.Fila == 0)
                {
                    c4f1.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 3 && a.Fila == 0)
                {
                    c4f1.Background = Brushes.Yellow;
                }
            }
        }

        private void c1f2_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 0 && a.Fila == 1)
                {
                    c1f2.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 0 && a.Fila == 1)
                {
                    c1f2.Background = Brushes.Yellow;
                }
            }
        }

        private void c2f2_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 1 && a.Fila == 1)
                {
                    c2f2.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 1 && a.Fila == 1)
                {
                    c2f2.Background = Brushes.Yellow;
                }
            }
        }

        private void c3f2_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 2 && a.Fila == 1)
                {
                    c3f2.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 2 && a.Fila == 1)
                {
                    c3f2.Background = Brushes.Yellow;
                }
            }
        }

        private void c4f2_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 3 && a.Fila == 1)
                {
                    c4f2.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 3 && a.Fila == 1)
                {
                    c4f2.Background = Brushes.Yellow;
                }
            }
        }

        private void c1f3_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 0 && a.Fila == 2)
                {
                    c1f3.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 0 && a.Fila == 2)
                {
                    c1f3.Background = Brushes.Yellow;
                }
            }
        }

        private void c2f3_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 1 && a.Fila == 2)
                {
                    c2f3.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 1 && a.Fila == 2)
                {
                    c2f3.Background = Brushes.Yellow;
                }
            }
        }

        private void c3f3_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 2 && a.Fila == 2)
                {
                    c3f3.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 2 && a.Fila == 2)
                {
                    c3f3.Background = Brushes.Yellow;
                }
            }
        }

        private void c4f3_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 3 && a.Fila == 2)
                {
                    c4f3.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 3 && a.Fila == 2)
                {
                    c4f3.Background = Brushes.Yellow;
                }
            }
        }

        private void c1f4_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 0 && a.Fila == 3)
                {
                    c1f4.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 0 && a.Fila == 3)
                {
                    c1f4.Background = Brushes.Yellow;
                }
            }
        }

        private void c2f4_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 1 && a.Fila == 3)
                {
                    c2f4.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 1 && a.Fila == 3)
                {
                    c2f4.Background = Brushes.Yellow;
                }
            }
        }

        private void c3f4_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 2 && a.Fila == 3)
                {
                    c3f4.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 2 && a.Fila == 3)
                {
                    c3f4.Background = Brushes.Yellow;
                }
            }
        }

        private void c4f4_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in asientos)
            {
                if (a.Estado.Equals("comprado") && a.Columna == 3 && a.Fila == 3)
                {
                    c4f4.Background = Brushes.DarkOliveGreen;
                }
                else if (a.Estado.Equals("reservado") && a.Columna == 3 && a.Fila == 3)
                {
                    c4f4.Background = Brushes.Yellow;
                }
            }
        }
    }
}
