using probando1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entrega2_Equipo1;

namespace ptobandoForms
{
    public partial class Form1 : Form
    {
        ProgramManager programManager = new ProgramManager();
        Entrega2_Equipo1.Library library;
        private readonly string DEFAULT_LIBRARY_PATH = @"C:\Users\torre\Desktop\finalProject\Entrega 2\Entrega2_Equipo1\Files\library.bin";
        StringBuilder pattern;
    public Form1()
        {
            pattern = new StringBuilder();
            LoadLibrary();
            InitializeComponent();
        }

        public void LoadLibrary()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(this.DEFAULT_LIBRARY_PATH, FileMode.Open, FileAccess.Read, FileShare.None);
            Entrega2_Equipo1.Library library = (Entrega2_Equipo1.Library)formatter.Deserialize(stream);
            stream.Close();
            this.library = library;
        }

        
        private void SmartList_Click(object sender, EventArgs e)  //Button para mostrar las smart list en el panel
        {
            ImageSmartPanel.Controls.Clear();
            library.UpdateSmartList(library.Images);
            foreach (KeyValuePair<string, List<Entrega2_Equipo1.Image>> val in library.SmartList)
            {
                ListSmartDelete.Items.Add(val.Key);
            }
            Dictionary<string, List<Entrega2_Equipo1.Image>> dicc = library.SmartList;
            int altura = 20;
            MuestraSmartPanel.Controls.Clear();
            ListSmartDelete.Items.Clear();
            foreach (KeyValuePair<string, List<Entrega2_Equipo1.Image>> nuevo in dicc)
            {
                Button button = new Button();
                button.Name = nuevo.Key;
                button.Text = nuevo.Key;
                button.ForeColor = Color.White;
              
                button.MaximumSize = new System.Drawing.Size(150, 23);
                button.Click += new EventHandler((sender1, e1) => OnImagenes(sender1, e1, nuevo.Value));
                button.Location = new System.Drawing.Point(12, altura);
                MuestraSmartPanel.Controls.Add(button);
                ListSmartDelete.Items.Add(nuevo.Key);
                altura += 20;
            }
        }
        
        private void OnImagenes(object sender1, EventArgs e1, List<Entrega2_Equipo1.Image> seccion)  // Crea las funciones de cada smart list
        {

            int lado = 20;
            Button button1 = (Button)sender1;
            ImageSmartPanel.Controls.Clear();
            foreach (Entrega2_Equipo1.Image pala in seccion)
            {

                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = pala.Name;
                pictureBox.Image = (System.Drawing.Image)pala.BitmapImage;
                pictureBox.Location = new System.Drawing.Point(lado, 12);
                label.Text = pala.Name;
                label.Location = new System.Drawing.Point(lado+10, 70);
                label.ForeColor=Color.White;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                ImageSmartPanel.Controls.Add(pictureBox);
                ImageSmartPanel.Controls.Add(label);
                lado += 110;
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddSmarListButton_Click(object sender, EventArgs e)  //Abrir el panel para crear  smart list
        {
            MuestraSmartPanel.Controls.Clear();
            ImageSmartPanel.Controls.Clear();
            SeacherPattern.Text = "Seacher Pattern";
            busqueda.Text = "Busqueda";
            OpcionesPanel.Visible = false;
            addSmart.Visible = true; 
            ImageSmartPanel.Controls.Add(addSmart);      

            
        }

        private void AddSmartListButton_Click(object sender, EventArgs e)  //Agrega a un string el patron que se quiere buscar
        {
            
            System.Text.StringBuilder patron = new System.Text.StringBuilder();
            
            while (true)
            {
                string parametro = busqueda.SelectedItem.ToString();
                switch (parametro)
                {
                    case "Sentence:":
                        patron.Append(busqueda.SelectedItem + SentenceBox.Text);
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Name:":
                        patron.Append(busqueda.SelectedItem + SentenceBox.Text);
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Surname:":
                        patron.Append(busqueda.SelectedItem + SentenceBox.Text);
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Filter:":
                        patron.Append(busqueda.SelectedItem + FiltroComboBox.SelectedItem.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Birthdate:":
                        patron.Append(busqueda.SelectedItem + BirthDate.Value.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Sex:":
                        patron.Append(busqueda.SelectedItem + SexComboBox.SelectedItem.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "EyesColor:":
                        patron.Append(busqueda.SelectedItem + ColorComboBox.SelectedItem.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "HairColor:":
                        patron.Append(busqueda.SelectedItem + ColorComboBox.SelectedItem.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Nationality:":
                        patron.Append(busqueda.SelectedItem + NationalityComboBox.SelectedItem.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "GeographicLocation:":
                        patron.Append(busqueda.SelectedItem + Latitud.Value.ToString()+","+Longitud.Value.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Address:":
                        patron.Append(busqueda.SelectedItem + SentenceBox.Text);
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Photographer:":
                        patron.Append(busqueda.SelectedItem + SentenceBox.Text);
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Photomotive:":
                        patron.Append(busqueda.SelectedItem + SentenceBox.Text);
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Selfie:":
                        patron.Append(busqueda.SelectedItem + YesNo.SelectedItem.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;
                    case "Calification:":
                        patron.Append(busqueda.SelectedItem + CalificationUp.Value.ToString());
                        if (UnionComboBox.SelectedItem.ToString() == "and")
                        {
                            patron.Append(" and ");
                        }
                        else if (UnionComboBox.SelectedItem.ToString() == "or")
                        {
                            patron.Append(" or ");
                        }
                        break;


                }
                pattern.Append(patron.ToString());
                SeacherPattern.Text = pattern.ToString();
                break;
            }
           
            
        }

        private void Atras_Click(object sender, EventArgs e)  //vuelve  atras
        {
            addSmart.Visible = false;
            SeacherPattern.Text = "Seacher Pattern";
            pattern.Clear();
            busqueda.Text = "Busqueda";
        }

        private void DeleteButtom_Click(object sender, EventArgs e)  //elimina la smart list
        {
            string palabra = ListSmartDelete.SelectedItem.ToString();
            library.RemoveSmartList(palabra);
            DeletePanel.Visible = false;
        }

        private void DeleteSmartButton_Click(object sender, EventArgs e)  //muestra el panel de las smart list para eliminar
        {
            MuestraSmartPanel.Controls.Clear();
            ImageSmartPanel.Controls.Clear();
            DeletePanel.Visible = true;
            ImageSmartPanel.Controls.Add(DeletePanel);
            
        }

        private void Atras1_Click(object sender, EventArgs e)  //cierra la ventana
        {
            DeletePanel.Visible = false;
        }


        private void Agregar_Click(object sender, EventArgs e)  // agrega el patron de busqueda a las smart list
        {
   
            library.AddSmartList(pattern.ToString(), library.Images);
            addSmart.Visible = false;
            SeacherPattern.Text = "Seacher Pattern";
            pattern.Clear();
            busqueda.Text = "Busqueda";
        }

        private void Busqueda_SelectedIndexChanged(object sender, EventArgs e)  //maneja las opciones de muestra segun la seleccion para el patron
        {
            OpcionesPanel.Visible = true;
            if (busqueda.SelectedItem.ToString() == "Sentence:" || busqueda.SelectedItem.ToString() == "Name:" || busqueda.SelectedItem.ToString() == "Surname:" || busqueda.SelectedItem.ToString() == "Address:" || busqueda.SelectedItem.ToString() == "Photographer:" || busqueda.SelectedItem.ToString() == "Photomotive:" )
            {
                
                OpcionesPanel.Controls.Clear();
                SentenceBox.Text = "Sentence";
                SentenceBox.Visible = true;
                UnionComboBox.Visible = true;
                AddButton.Visible = true;
                OpcionesPanel.Controls.Add(SentenceBox);
            }
            else if(busqueda.SelectedItem.ToString() == "GeographicLocation:")
            {
                OpcionesPanel.Controls.Clear();
                Longitud.ResetText();
                Latitud.ResetText();
                Longitud.Visible = true;
                Latitud.Visible = true;
                UnionComboBox.Visible = true;
                AddButton.Visible = true;
                OpcionesPanel.Controls.Add(Longitud);
                OpcionesPanel.Controls.Add(Latitud);
            }
            else if (busqueda.SelectedItem.ToString() == "Selfie:")
            {
                OpcionesPanel.Controls.Clear();
                YesNo.ResetText();
                YesNo.Visible = true;
                UnionComboBox.Visible = true;
                AddButton.Visible = true;
                OpcionesPanel.Controls.Add(YesNo);
            }
            else if (busqueda.SelectedItem.ToString() == "Nationality:")
            {
                OpcionesPanel.Controls.Clear();
                NationalityComboBox.ResetText();
                NationalityComboBox.Visible = true;
                UnionComboBox.Visible = true;
                AddButton.Visible = true;
                OpcionesPanel.Controls.Add(NationalityComboBox);
            }
            else if (busqueda.SelectedItem.ToString() == "HairColor:" || busqueda.SelectedItem.ToString() == "EyesColor:")
            {
                OpcionesPanel.Controls.Clear();
                ColorComboBox.ResetText();
                ColorComboBox.Visible = true;
                UnionComboBox.Visible = true;
                AddButton.Visible = true;
                OpcionesPanel.Controls.Add(ColorComboBox);
            }
            else if (busqueda.SelectedItem.ToString() == "Sex:")
            {
                OpcionesPanel.Controls.Clear();
                SexComboBox.ResetText();
                SexComboBox.Visible = true;
                UnionComboBox.Visible = true;
                AddButton.Visible = true;
                OpcionesPanel.Controls.Add(SexComboBox);
            }
            else if (busqueda.SelectedItem.ToString() == "Birthdate:")
            {
                OpcionesPanel.Controls.Clear();
                BirthDate.ResetText();
                BirthDate.Visible = true;
                UnionComboBox.Visible = true;
                AddButton.Visible = true;
                OpcionesPanel.Controls.Add(BirthDate);
            }
            else if (busqueda.SelectedItem.ToString() == "Filter:")
            {
                OpcionesPanel.Controls.Clear();
                FiltroComboBox.ResetText();
                UnionComboBox.Visible = true;
                AddButton.Visible = true;
                FiltroComboBox.Visible = true;
                OpcionesPanel.Controls.Add(FiltroComboBox);
            }
            else if (busqueda.SelectedItem.ToString() == "Calification:")
            {
                OpcionesPanel.Controls.Clear();
                CalificationUp.ResetText();
                CalificationUp.Visible = true;
                AddButton.Visible = true;
                UnionComboBox.Visible = true;
                OpcionesPanel.Controls.Add(CalificationUp);
            }
            OpcionesPanel.Controls.Add(UnionComboBox);
            OpcionesPanel.Controls.Add(AddButton);
        }

        private void SeacherPattern_TextChanged(object sender, EventArgs e)  //srive cuando se elimina algo
        {
            pattern = new StringBuilder (SeacherPattern.Text);
        }

    }
}
